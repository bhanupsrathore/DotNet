class SecondsComparer : IComparer<Interval>
{
    public int Compare(Interval x, Interval y)
    {
        return x.Seconds - y.Seconds;
    }
}