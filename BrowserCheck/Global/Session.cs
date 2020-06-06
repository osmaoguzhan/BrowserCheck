using BrowserCheck.Model;
namespace BrowserCheck.Global
{
    public class Session
    {
        private static Session _Instance;

        public static Session Instance
        {

            get
            {
                if(_Instance == null)
                {
                    _Instance = new Session();
                }
                return (_Instance);
            }
        }

        private Session()
        {

        }

        public User MyUser = new User();
        public bool isLoggedIn
        {
            get
            {
                if(MyUser != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public void clearSession()
        {
            MyUser = null;
        }
    }
}
