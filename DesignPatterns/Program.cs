// See https://aka.ms/new-console-template for more information
//using DesignPatterns.Builder;
//using DesignPatterns.FluentBuilder;
//using DesignPatterns.StepwiseBuilder;

// Console.WriteLine("Hello, World!");
//new BasicHtmlElement().GetBasicHtmlElement();
//new BasicHtmlElement().GetComplicatedHtmlElement();

//var builder = new HtmlBuilder("ul");
//builder.AddChild("li", "hello");
//builder.AddChild("li", "world");
//builder.AddChild("li", "dev");

//builder.AddChild("li", "work 1").AddChild("li", "work 2");

//Console.WriteLine(builder.ToString());

//var me = Person.New
//    .Called("Juan")
//    .WorksAsA("Developer")
//    .Build();

//Console.WriteLine(me);

//var car = CarBuilder.Create() // ISpecifyCarType
//    .OfType(CarType.Crossover) // ISpecifyWheelSize
//    .WithWheels(18) // IBuildCar
//    .Build();

//using DesignPatterns.FunctionalBuilder;

//var person = new PersonBuilder()
//    .Called("Sarah")
//    .WorkAs("Developer")
//    .Build();

//using DesignPatterns.Faceted;

//var pb = new PersonBuilder();
//Person person = pb
//    .Lives.At("123 London Road")
//        .In("London")
//        .WithPostCode("asd21")
//    .Works.At("Fabrikan")
//        .AsA("Engineer")
//        .Earning(12300);

//Console.WriteLine(person);

using DesignPatterns;

var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
Console.WriteLine(cb);
