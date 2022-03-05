using System.Net;

class Server
{
    public static void Run()
    {
        Shop shop = Shop.Open("store.xml");
        var listener = new HttpListener();
        listener.Prefixes.Add("http://localhost:5000/shop/");
        listener.Start();
        for(;;)
        {
            var client = listener.GetContext();
            using var writer = new StreamWriter(client.Response.OutputStream);
            string item = client.Request.Url.Segments[2];
            string info = shop.GetItemInfo(item);
            if(info is not null)
            {
                client.Response.ContentType = "text/plain";
                writer.WriteLine(info);
            }
            else
                client.Response.StatusCode = 404;
        }
    }
}
