namespace LabTaskClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Human human1=new Human("Punhan","Aliyeva",21,"Siyazan");
           Human human2=new Human("Aygun","Shahmuradova",22,"Xachmaz");
           Human human3=new Human("Selma","Mammedli",17,"Siyazan");
           Human human4=new Human("Ali","Aliyev",18,"Baku");



            //Console.WriteLine(human1.IsStudent());
            //Console.WriteLine(human2.IsStudent());
            //Console.WriteLine(human3.IsStudent());
            //Console.WriteLine(human4.IsStudent());


            Human human = new();
            //human.CheckCity(human1.City,human2.City,human3.City,human4.City);

            Human[] humans = {human1,human2,human3,human4};
            human.GetCount(humans);



        }
    }
}