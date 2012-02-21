namespace RobotsTxt {
    internal class CrawlDelayRule : Rule {
        public long Delay { get; private set; } //milliseconds
        public CrawlDelayRule(string userAgent, Line line, int order)
            : base(userAgent, order) {
            double delay = 0;
            double.TryParse(line.Value, out delay);
            Delay = (long)(delay * 1000);
        }
    }
}