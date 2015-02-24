namespace API
{
    using Nancy;

    using STAROCK.DAL;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                

                    return Test.Conn();
            };
        }
    }
}