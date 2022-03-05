using Tourism;

//conditional compilation (see DemoApp.csproj)
#if USE_JSON
ISiteStore store = new Tourism.Persistence.JsonSiteStore();
#else
ISiteStore store = new Tourism.Persistence.XmlSiteStore();
#endif
Site site = store.Load("CitiZoo");
if(args.Length > 0)
{
    Visitor visitor = site.GetVisitor(args[0]);
    long tok = visitor.Visit();
    Console.WriteLine("Welcome {0}, your ticket number is {1}", visitor.Id, tok);
    store.Save(site);
}
else
{
    foreach(Visitor visitor in site.Visitors)
        Console.WriteLine("{0}\t{1}\t{2}", visitor.Id, visitor.VisitCount, visitor.LastVisit);
}
