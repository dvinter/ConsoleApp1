using System.Diagnostics;
using System.Reflection.PortableExecutable;

try
{
    // Create a DirectoryEntry object to connect to the Active Directory
    DirectoryEntry directoryEntry = new DirectoryEntry("LDAP://your-domain-controller", "username", "password");

    // Create a DirectorySearcher object to perform the search
    DirectorySearcher directorySearcher = new DirectorySearcher(directoryEntry);

    // Set the filter to retrieve all user objects
    directorySearcher.Filter = "(objectCategory=user)";

    // Perform the search and retrieve the result
    SearchResultCollection searchResults = directorySearcher.FindAll();

    // Iterate over the search results and print user details
    foreach (SearchResult searchResult in searchResults)
    {
        DirectoryEntry userEntry = searchResult.GetDirectoryEntry();
        Console.WriteLine("Username: " + userEntry.Properties["samaccountname"].Value);
        Console.WriteLine("Display Name: " + userEntry.Properties["displayname"].Value);
        Console.WriteLine("Email Address: " + userEntry.Properties["mail"].Value);
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}

static void Convert (float price)
{
    object objPrice = price;

    int newPrice = (int) (Double)objPrice;

    Debug.Write(newPrice);

    Console.WriteLine(newPrice);
}