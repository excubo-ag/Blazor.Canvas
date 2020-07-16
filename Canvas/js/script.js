window.Excubo = window.Excubo || {};
window.Excubo.Canvas = window.Excubo.Canvas || {
    batch: (ctx, ops) => {
        ctx = window[`${ctx}`];
        // for variables in js-land, we need to decode them from path string to variable, e.g. "foo.bar" refers to window.foo.bar, hence we need to perform window['foo']['bar']
        d = (e) => {
            let o1 = window;
            for (let part of e.split('.')) {
                o1 = o1[part];
            }
            return o1;
        }
        for (let op of ops) {
            switch (op.t) {
                case 'S': // Set
                    // the value op.v is set to the identifier op.i
                    ctx[op.i] = op.v;
                    break;
                case 'G': // Gradient/Pattern
                    // we generate a gradient (linear/radial) or pattern, which we have encoded in op.o1 ('L', 'R', or 'P'), and with args op.v and color stops / image in op.o2.
                    if (op.o1 == 'P') {
                        ctx[op.i] = ctx.createPattern(d(op.o2), op.v);
                    } else {
                        let g = ctx[`create${op.o1 == 'L' ? 'Linear' : 'Radial'}Gradient`](...op.v);
                        for (let cs of op.o2) {
                            g.addColorStop(cs.offset, cs.color);
                        }
                        ctx[op.i] = g;
                    }
                    break;
                case 'I': // Invoke
                    // the value(s) op.v are used as args on the function op.i
                    if (op.v == undefined) {
                        ctx[op.i]();
                    } else if (Array.isArray(op.v)) {
                        ctx[op.i](...op.v);
                    } else {
                        ctx[op.i](op.v);
                    }
                    break;
                case 'C': // Complex
                    // the js variables o1/o2 are used as first/second arg on the function op.i with more args op.v
                    if (op.o2 == undefined) {
                        if (op.v == undefined) {
                            ctx[op.i](d(op.o1));
                        } else if (Array.isArray(op.v)) {
                            ctx[op.i](d(op.o1), ...op.v);
                        } else {
                            ctx[op.i](d(op.o1), op.v);
                        }
                    } else {
                        if (op.v == undefined) {
                            ctx[op.i](d(op.o1), d(op.o2));
                        } else if (Array.isArray(op.v)) {
                            ctx[op.i](d(op.o1), d(op.o2), ...op.v);
                        } else {
                            ctx[op.i](d(op.o1), d(op.o2), op.v);
                        }
                    }
                    break;
            }
        }
    }
};