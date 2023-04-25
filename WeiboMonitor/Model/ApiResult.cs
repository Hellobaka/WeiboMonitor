namespace WeiboMonitor.Model
{
    public class ApiResult<T>
    {
        public bool Success { get; set; } = true;
      
        public T Object { get; set; }

        public string Message { get; set; } = "";
    }
}
