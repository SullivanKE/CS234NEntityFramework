using CS234NEntityFramework.Models;

namespace CS234NEntityFramework.Data
{
    public static class RoleNav
    {
        public static Dictionary<string, List<string>> GetRoleNav(string role)
        {
            Dictionary<string, List<string>> nav = new Dictionary<string, List<string>>();
            nav.TryAdd("Home", new List<string>());
            nav["Home"].Add("Test Link 1");
            nav["Home"].Add("Test Link 2");
            nav["Home"].Add("Test Link 3");
            nav["Home"].Add("Test Link 4");
            switch (role)
            {
                case "Admin":
                    
                    nav.TryAdd("Pub", new List<string>());
                    nav["Pub"].Add("Test Link 1");
                    nav["Pub"].Add("Test Link 2");
                    nav["Pub"].Add("Test Link 3");
                    nav["Pub"].Add("Test Link 4");
                    nav.TryAdd("Sales", new List<string>());
                    nav["Sales"].Add("Test Link 1");
                    nav["Sales"].Add("Test Link 2");
                    nav["Sales"].Add("Test Link 3");
                    nav["Sales"].Add("Test Link 4");
                    nav.TryAdd("Accounts", new List<string>());
                    nav["Accounts"].Add("Test Link 1");
                    nav["Accounts"].Add("Test Link 2");
                    nav["Accounts"].Add("Test Link 3");
                    nav["Accounts"].Add("Test Link 4");
                    nav.TryAdd("Brew", new List<string>());
                    nav["Brew"].Add("Test Link 1");
                    nav["Brew"].Add("Test Link 2");
                    nav["Brew"].Add("Test Link 3");
                    nav["Brew"].Add("Test Link 4");
                    nav.TryAdd("Admin", new List<string>());
                    nav["Admin"].Add("Test Link 1");
                    nav["Admin"].Add("Test Link 2");
                    nav["Admin"].Add("Test Link 3");
                    nav["Admin"].Add("Test Link 4");
                    break;
                case "Brewer":
                    nav.TryAdd("Brew", new List<string>());
                    nav["Brew"].Add("Test Link 1");
                    nav["Brew"].Add("Test Link 2");
                    nav["Brew"].Add("Test Link 3");
                    nav["Brew"].Add("Test Link 4");
                    break;
                case "Sales":
                    nav.TryAdd("Sales", new List<string>());
                    nav["Sales"].Add("Test Link 1");
                    nav["Sales"].Add("Test Link 2");
                    nav["Sales"].Add("Test Link 3");
                    nav["Sales"].Add("Test Link 4");
                    break;
                case "Client":
                    // Something here maybe?
                    break;
                case "Accountant":
                    nav.TryAdd("Sales", new List<string>());
                    nav["Sales"].Add("Test Link 1");
                    nav["Sales"].Add("Test Link 2");
                    nav["Sales"].Add("Test Link 3");
                    nav["Sales"].Add("Test Link 4");
                    nav.TryAdd("Accounts", new List<string>());
                    nav["Accounts"].Add("Test Link 1");
                    nav["Accounts"].Add("Test Link 2");
                    nav["Accounts"].Add("Test Link 3");
                    nav["Accounts"].Add("Test Link 4");
                    break;
                default:
                    // Something here maybe?
                    break;
            }


            return nav;
        }
    }
}
