namespace WebApiTest.Service
{
    public class EndpointResult<T>
    {
        public T[] Result { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}