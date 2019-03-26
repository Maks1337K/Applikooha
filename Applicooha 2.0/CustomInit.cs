namespace Applicooha_2._0
{
    using System.Data.Entity;

    internal class CustomInit<T> : DropCreateDatabaseIfModelChanges<Factory>
    {
        protected override void Seed(Factory context)
        {
            base.Seed(context);
            context.Workers.Add(new Worker
            {
                FirstName = "Petro",
                LastName = "Petrenko",
                Gender = "Montagnik",
                Salary = 9999m,
                Adress = "Rivne, Soborna str., 56"
            });
            base.Seed(context);
            context.Workers.Add(new Worker
            {
                FirstName = "Ivan",
                LastName = "Ivanenko",
                Gender = "male",
                Salary = 19999m,
                Adress = "Lutsk, Rivnenka str., 112"
            });
            base.Seed(context);
            context.Workers.Add(new Worker
            {
                FirstName = "Vitalik",
                LastName = "Klichko",
                Gender = "Mer",
                Salary = 1005000m,
                Adress = "Kyiv, Nezalezhnosti maidan., 1"
            });
        }
    }
}