namespace Logging
{
    public class Result
    {
        private bool _status;
        private string _errorMessage;

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set 
            { 
                if(value!=null)
                {
                    _errorMessage = value;
                }
                
            }
        }

        public Result(bool status, string errorMessage)        {
            Status = status;
            ErrorMessage = errorMessage;
        }

    }
}
