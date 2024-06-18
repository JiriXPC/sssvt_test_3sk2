namespace pokrocileOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FullName = "Nové jméno";
            Console.WriteLine(student.FullName);

            student.Normal = true;
            Console.WriteLine(student.Normal);

            student.Birthday = DateTime.Now;
            Console.WriteLine(student.Birthday.ToLongDateString());

            Teacher teacher = new Teacher();
            teacher.FullName = "Jmeno učitele";
            teacher.GetIsNormal;

            Kruh kruh = new Kruh();
            kruh.ZiskejObvod();

            Tvar kruh2 = new Kruh();
            kruh2.ZiskejObsah();
            kruh2.ZiskejObvod();

            Tvar ctverec = new Ctverec();
            ctverec.ZiskejObsah();
            ctverec.ZiskejObvod();

            List<Kruh> kolekceTvaru = new List<Kruh>();
            kolekceTvaru.Add(kruh);
            kolekceTvaru.Add(kruh2);
            kolekceTvaru.Add(ctverec);
        }
    }
}