using Dal;

using (MacContext context = new MacContext())
{
    context.Initialize(true);
}

Console.WriteLine("OKI");
