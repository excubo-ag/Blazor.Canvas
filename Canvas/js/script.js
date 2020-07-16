window.Excubo = window.Excubo || {};
window.Excubo.Canvas = window.Excubo.Canvas || {
    batch: (ctx, ops) => {
        ctx = window[`${ctx}`];
        for (let op of ops) {
            switch (op.t) {
                case 'S':
                    ctx[op.i] = op.v;
                    break;
                case 'I':
                    if (op.v == undefined) {
                        ctx[op.i]();
                    } else if (Array.isArray(op.v)) {
                        ctx[op.i](...op.v);
                    } else {
                        ctx[op.i](op.v);
                    }
                    break;
                case 'C':
                    d = (e) => {
                        let o1 = window;
                        for (const part of e.split('.')) {
                            o1 = o1[part];
                        }
                        return o1;
                    }
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