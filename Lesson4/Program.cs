#region Website
//WebSite web = new WebSite();
//web.info();
//class WebSite
//{
//    private string name;
//    private string url;
//    private string description;
//    private decimal ipAddress;

//    public void setName(string name)
//    {
//        this.name = name;
//    }

//    public void setUrl(string url)
//    {
//        url = "www." + url + ".com";
//        this.url = url;
//    }

//    public void setDescription(string description)
//    {
//        this.description = description;
//    }

//    public void setIpAddress(decimal ipAddress)
//    {
//        if (ipAddress > 19200000 && ipAddress < 19299999)
//        {
//            this.ipAddress = ipAddress;
//        }
//        else
//        {
//            this.ipAddress = 0;
//        }
//    }

//    public string getName() 
//    { 
//        return this.name;
//    }
//    public string getUrl() 
//    { 
//        return this.url;
//    }
//    public string getDescription() 
//    { 
//        return this.description;
//    }
//    public decimal getIpAddress() 
//    { 
//        return this.ipAddress;
//    }

//    public void info()
//    {
//        Console.Write("Enter site name: - ");
//        setName(Console.ReadLine());
//        Console.Write("Enter URL - ");
//        setUrl(Console.ReadLine());
//        Console.Write("Enter Description - ");
//        setDescription(Console.ReadLine());
//        Console.Write("Enter Ip Address - ");
//        setIpAddress(Convert.ToDecimal(Console.ReadLine()));

//        Console.WriteLine($"Name - {getName()} ");
//        Console.WriteLine($"Url - {getUrl()} ");
//        Console.WriteLine($"Description - {getDescription()} ");
//        Console.WriteLine($"Ip Address - {getIpAddress()} ");
//    }
//}
#endregion

#region Magazine
//Magazine magazine = new Magazine();
//magazine.info();

//class Magazine
//{ 
//    private string magazineName;
//    private int yearOfFoundation;
//    private string logDescription;
//    private int contactNumber;
//    private string Email;

//    public void setMagazineName(string magazineName)
//    {
//        this.magazineName = magazineName;
//    }

//    public void setYearOfFoundation(int yearOfFoundation)
//    {
//        if (yearOfFoundation > 1950 && yearOfFoundation < 2023) 
//        {
//            this.yearOfFoundation = yearOfFoundation;
//        }
//        else
//        {
//            this.yearOfFoundation = 0;
//        }
//    }

//    public void setLogDescription(string logDescription)
//    {
//        this.logDescription = logDescription;
//    }

//    public void setContactNumber(int contactNumber)
//    {
//        if (contactNumber > 111111111 && contactNumber < 999999999)
//        {
//            this.contactNumber = contactNumber;
//        }
//        else
//        {
//            this.contactNumber = 0;
//        }
//    }

//    public void setEmail(string email)
//    {
//        email += "@email.ru";
//        this.Email = email;
//    }

//    public string getMagazineName()
//    {
//        return this.magazineName;
//    }

//    public int getYearOfFoundation() 
//    { 
//        return this.yearOfFoundation; 
//    }

//    public string getLogDescription()
//    {
//        return this.logDescription;
//    }

//    public int getContactNumber()
//    {
//        return this.contactNumber;
//    }

//    public string getEmail()
//    {
//        return this.Email;
//    }
//    public void info()
//    {
//        Console.Write("Enter magazine name - ");
//        setMagazineName(Console.ReadLine());
//        Console.Write("Enter year of foundation - ");
//        setYearOfFoundation(Convert.ToInt32(Console.ReadLine()));
//        Console.Write("Enter log description - ");
//        setLogDescription(Console.ReadLine());
//        Console.Write("Enter contact number - ");
//        setContactNumber(Convert.ToInt32(Console.ReadLine()));
//        Console.Write("Enter email - ");
//        setEmail(Console.ReadLine());

//        Console.WriteLine();

//        Console.WriteLine($"Magazine name - {getMagazineName()}");
//        Console.WriteLine($"Year of foundation - {getYearOfFoundation()}");
//        Console.WriteLine($"Log description - {getLogDescription()}");
//        Console.WriteLine($"Contact number - {getContactNumber()}");
//        Console.WriteLine($"Email - {getEmail()}");
//    }
//}
#endregion

#region Shop
//Shop shop = new Shop();
//shop.info();

//class Shop
//{
//    private string nameShop;
//    private string address;
//    private string description;
//    private int contactNumber;
//    private string Email;


//    public void setNameShop(string nameShop)
//    {
//        this.nameShop = nameShop;
//    }

//    public void setAddress(string address) 
//    {
//        this.address = address;
//    }

//    public void setDescription(string description)
//    {
//        this.description = description;
//    }

//    public void setContactNumber(int contactNumber)
//    {
//        if (contactNumber > 111111111 && contactNumber < 999999999)
//        {
//            this.contactNumber = contactNumber;
//        }
//        else
//        {
//            this.contactNumber = 0;
//        }
//    }

//    public void setEmail(string email)
//    {
//        email += "@email.ru";
//        this.Email = email;
//    }

//    public string getNameShop()
//    {
//        return this.nameShop;
//    }

//    public string getAddress()
//    {
//        return this.address;
//    }

//    public string getDescription() 
//    {
//        return this.description;
//    }

//    public int getContactNumber()
//    {
//        return this.contactNumber;
//    }

//    public string getEmail()
//    {
//        return this.Email;
//    }

//    public void info()
//    {
//        Console.Write("Enter Name Shop - ");
//        setNameShop(Console.ReadLine());
//        Console.Write("Enter Address - ");
//        setAddress(Console.ReadLine());
//        Console.Write("Enter description - ");
//        setDescription(Console.ReadLine());
//        Console.Write("Enter contact number - ");
//        setContactNumber(Convert.ToInt32(Console.ReadLine()));
//        Console.Write("Enter email - ");
//        setEmail(Console.ReadLine());

//        Console.WriteLine();

//        Console.WriteLine($"Name Shop - {getNameShop()}");
//        Console.WriteLine($"Address - {getAddress()}");
//        Console.WriteLine($"Description - {getDescription()}");
//        Console.WriteLine($"Contact number - {getContactNumber()}");
//        Console.WriteLine($"Email - {getEmail()}");
//    }
//}
#endregion