namespace Excubo.Blazor.Canvas.Contexts
{
    public class TextMetrics
    {
        public double Width { get; set; }
        public double ActualBoundingBoxLeft { get; set; }
        public double actualBoundingBoxRight { get; set; }
        public double fontBoundingBoxAscent { get; set; }
        public double fontBoundingBoxDescent { get; set; }
        public double actualBoundingBoxAscent { get; set; }
        public double actualBoundingBoxDescent { get; set; }
        public double emHeightAscent { get; set; }
        public double emHeightDescent { get; set; }
        public double hangingBaseline { get; set; }
        public double alphabeticBaseline { get; set; }
        public double ideographicBaseline { get; set; }
    }
}
