using DesignPattern.Behavioral.Command;
using DesignPattern.Behavioral.Interpreter;
using DesignPattern.Behavioral.Iterator;
using DesignPattern.Behavioral.Mediator;
using DesignPattern.Behavioral.Memento;
using DesignPattern.Behavioral.Observer;
using DesignPattern.Behavioral.Strategy;
using DesignPattern.Behavioral.TemplateMethod;
using DesignPattern.Behavioral.Visitor;
using DesignPattern.ChainOfResponsibility;
using DesignPattern.CreationalPatterns.Builder;
using DesignPattern.CreationalPatterns.Prototype;
using DesignPattern.Structural.Adapter;
using DesignPattern.Structural.Bridge;
using DesignPattern.Structural.Composite;
using DesignPattern.Structural.Decorator;
using DesignPattern.Structural.Facade;
using DesignPattern.Structural.Flyweight;
using DesignPattern.Structural.Proxy;
using KodOrnek.CreationalPatterns.AbstractFactory;
using KodOrnek.CreationalPatterns.Factory;
using KodOrnek.Singleton;
using System;
using Customer = DesignPattern.CreationalPatterns.Prototype.Customer;

namespace KodOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrototypeDesignPattern();
            //BuilderDesignPattern();
            //AbstractFactoryDesignPattern();
            //FactoryDesignPattern();
            //SingletonDesignPattern();

            //BridgeDesignPattern();
            //AdapterDesignPattern();
            //CompositeDesignPattern();
            //DecolatorDesignPattern();
            //FacadeDesignPattern();
            //FlyWeight();
            //Proxy();


            //ChainOfResponsibility();
            //Command();
            //Interpreter();
            //Iterator();
            //Mediator();
            //Memento();
            //Observer();
            //Strategy();
            //TemplateMethod();
            //Visitor();

        }

        private static void Visitor()
        {
            Book earth = new Encyclopedia();

            earth.name = "Big Earth!";
            earth.author = "Jose S. Massey";
            earth.categoryName = "Encyclopedia";

            Book daily = new Magazine();

            daily.name = "Daily Magazine";
            daily.author = "Wayne D. Eakin";
            daily.categoryName = "Magazine";


            IBookExportVisitor xmlExportVisitor = new XmlExportVisitor();
            IBookExportVisitor jsonExportVisitor = new JsonExportVisitor();

            earth.Accept(xmlExportVisitor);
            daily.Accept(jsonExportVisitor);
        }

        private static void TemplateMethod()
        {
            DataAnalyzerBase dataAnalyzer = new XmlDataAnalyzer();
            dataAnalyzer.AnalyzerDataOfLastWeek();
            // output:
            //  Method worked: GetDataOfLastWeek
            //  Method worked: AnalyzeData
            //  XML exported.

            dataAnalyzer = new HtmlDataAnalyzer();
            dataAnalyzer.AnalyzerDataOfLastWeek();
        }

        private static void Strategy()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new Item("894651364", 80));
            shoppingCart.AddItem(new Item("654798243", 20));

            shoppingCart.SetPaymentMethod(new PaypalPayment("yusufyilmazfr@gmail.com", "examplepassword"));
            shoppingCart.Pay(); // output: Paid by Paypal.


            shoppingCart.SetPaymentMethod(new CreditCartPayment("Julia Rodriguez", "4373093149845972", "199", "12/2024"));
            shoppingCart.Pay(); // output: Paid by credit cart.
        }

        private static void Observer()
        {
            // Güncellemeden etkilenecek olan sınıf örnekleri.
            IObserverUser mehmet = new ObserverUser();
            IObserverUser derya = new ObserverUser();
            IObserverUser sema = new ObserverUser();
            IObserverUser aleyna = new ObserverUser();


            // İzlenecek olan sınıf örneği.
            Samsung samsung = new Samsung();

            // İzlenecek olan sınıfa etkilenecek olan nesnelerin atanması.
            samsung.AddObserver(mehmet);
            samsung.AddObserver(derya);
            samsung.AddObserver(sema);
            samsung.AddObserver(aleyna);

            samsung.ChangePrice();
        }

        private static void Memento()
        {
            TextOriginator textOriginator = new TextOriginator();

            textOriginator.Text = "asm";
            textOriginator.CursorPosition = 3;

            // Anlık durum yığına ekleniyor.

            textOriginator.Save();


            textOriginator.Text = "asmi";
            textOriginator.CursorPosition = 4;

            // Anlık durum yığına ekleniyor.
            textOriginator.Save();

            textOriginator.Text = "asmin";
            textOriginator.CursorPosition = 5;

            // Anlık durum yığına ekleniyor.
            textOriginator.Save();

            // Yığındaki bir önceki duruma geçiyor.
            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());

            // Yığındaki bir önceki duruma geçiyor.
            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());

            // Yığındaki bir önceki duruma geçiyor.
            textOriginator.Undo();
            Console.WriteLine(textOriginator.ToString());
        }

        private static void Mediator()
        {
            IChatRoomMediator chatRoom = new ChatRoomMediator();

            // Sohbet odasına dahil olacak kullanıcıların oluşturulması.
            // Ortak Mediator arayüzü ile haberleşmesi.
            DesignPattern.Behavioral.Mediator.User yusuf = new ChatUser(chatRoom);
            yusuf.id = 1;
            yusuf.name = "Yusuf";

            DesignPattern.Behavioral.Mediator.User sema = new ChatUser(chatRoom);
            sema.id = 2;
            sema.name = "Semanur";

            DesignPattern.Behavioral.Mediator.User derya = new ChatUser(chatRoom);
            derya.id = 3;
            derya.name = "Derya";

            DesignPattern.Behavioral.Mediator.User aleyna = new ChatUser(chatRoom);
            aleyna.id = 4;
            aleyna.name = "Aleyna";

            // Mediator içerisindeki kullanıcı listesine atama işlemleri.
            chatRoom.AddUserInRoom(yusuf);
            chatRoom.AddUserInRoom(sema);
            chatRoom.AddUserInRoom(derya);
            chatRoom.AddUserInRoom(aleyna);

            yusuf.SendMessage("Naber kız?", sema.id);
            sema.SendMessage("Sanane be?", yusuf.id);
        }

        private static void Iterator()
        {
            EmployeeListAggregate employeeListAggregate = new EmployeeListAggregate();

            Employee yusuf = new Employee(1, "Yusuf", "Yılmaz");
            Employee arafat = new Employee(2, "Arafat", "Önlük");
            Employee derya = new Employee(3, "Derya", "Obi");

            employeeListAggregate.Add(yusuf);
            employeeListAggregate.Add(arafat);
            employeeListAggregate.Add(derya);

            var iterator = employeeListAggregate.CreateIterator();

            while (iterator.HasNext())
            {
                Employee currentEmployee = iterator.GetCurrentItem();
                Console.WriteLine($"{currentEmployee.firstName} {currentEmployee.lastName}");
            }
        }

        private static void Interpreter()
        {
            Context context = new Context();
            context.formul = "GGML";
            JobManager jobManager = new JobManager();
            jobManager.RunExpression(context);

            Console.WriteLine(context.formul + context.totalPoint);
        }

        private void Command()
        {
            StockManager stockManager = new StockManager("iPhone", 200);
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock = new SellStock(stockManager);
            StockController stockController = new StockController();

            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(sellStock);


        }
        private void ChainOfResponsibility()
        {

            Image image = new Image("tatil-fotografim", "JPG");

            JPEGHandler jpegHandler = new JPEGHandler();
            JPGHandler jpgHandler = new JPGHandler();
            CustomHandler customHandler = new CustomHandler();

            // Zincirlerin birbirleri ile bağlantısının yapıldığı yerdir.
            // JPEG bu işlemi gerçekleştiremezse JPG'e aktarır o da Custom'a aktarır.
            jpegHandler.SetNextHandler(jpgHandler);
            jpgHandler.SetNextHandler(customHandler);

            jpegHandler.HandleRequest(image);
        }

        private static void BridgeDesignPattern()
        {
            IMessageSender textMessageSender = new TextMessageSender();
            Message textMessage = new TextMessage(textMessageSender);
            textMessage.Send();

            IMessageSender emailMessageSender = new EmailMessageSender();
            Message emailMessage = new EmailMessage(emailMessageSender);
            emailMessage.Send();
        }

        private static void AdapterDesignPattern()
        {
            var customOperation = new CustomOperation(new CustomSerializerAdapter());
            string serializedObject = customOperation.SerializeObject(new object());
        }

        private static void PrototypeDesignPattern()
        {
            Customer engin = new Customer("Engin", "Can");
            Customer cloneGulizar = engin.Clone();
        }

        private static void BuilderDesignPattern()
        {
            var lessonBuilder = new NewStudentLessonBuilder();
            var lessonDirector = new LessonDirector(lessonBuilder);
            lessonDirector.Make();
            Lesson lesson = lessonBuilder.GetResult();

        }

        private static void AbstractFactoryDesignPattern()
        {
            ProductManager productManager = new ProductManager(new OracleDatabaseFactory());
            productManager.RemoveById(1);
        }

        private static void FactoryDesignPattern()
        {
            NotifyFactory notifyFactory = new NotifyFactory();
            INotifyService notify = notifyFactory.Create("MAIL");
            notify.Send(new CreationalPatterns.Factory.User());
        }

        private static void SingletonDesignPattern()
        {
            Singleton.Product product = Singleton.Product.GetInstance();
        }

        private static void Proxy()
        {
            Person engin = new Person("11111111111", "Aydın/Efeler");
            IOrderableMask orderableMask = new AuthentictableMaskOrderProxy();
            orderableMask.CreateOrder(engin);
        }

        private static void FlyWeight()
        {
            BoxFactory boxFactory = new BoxFactory();

            Box blackBox1 = boxFactory.Get(BoxColor.Black);
            Box blackBox2 = boxFactory.Get(BoxColor.Black);
        }

        private static void FacadeDesignPattern()
        {
            DesignPattern.Structural.Facade.Customer customer = new DesignPattern.Structural.Facade.Customer("Engin", "Can");
            CreditCardFacade creditCardFacade = new CreditCardFacade();
            creditCardFacade.CreateCreditCart(customer);
        }

        private static void DecolatorDesignPattern()
        {
            IDataSource dataSource = new FileDataSource("data.sql");
            IDataSource compressedDataSource = new ComporessionDecorator(dataSource);
            compressedDataSource.ReadData();
            compressedDataSource.WriteData(new object());
        }

        private static void CompositeDesignPattern()
        {
            var items = new ProductCatalog("Ürünler");
            var phones = new ProductCatalog("Telefonlar");
            var iphone = new ProductCatalog("İphone Telefon");
            var samsung = new ProductCatalog("Samsung Telefon");
            var iphone5Item = new DesignPattern.Structural.Composite.Product("Iphone 5");
            var samsungGalaxyItem = new DesignPattern.Structural.Composite.Product("Samsung Galaxy");

            //En Üst hiyararşiye Telefonlar eklendi
            items.Add(phones);
            //Telefonlar hiyararşisine iphone ve samsung ekledik
            phones.Add(iphone);
            phones.Add(samsung);

            //Iphone ve samsung hiyerarşisine Iphone5 ve samsung galaxy ekledik
            iphone.Add(iphone5Item);
            samsung.Add(samsungGalaxyItem);
            //hiyerarşiyi ekrana yazdık
            items.Hierarchy();
        }
    }
}
