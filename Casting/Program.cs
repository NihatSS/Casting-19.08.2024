#region Casting
using Casting;

Animal a = new Shark();

Animal[] animals = { a, new Owl(), new Parrot(), new Cat(), new Duck() };
foreach (var animal in animals)
{
    if (animal is Shark newShark)
    {
        //Shark newShark = (Shark)animal;
        newShark.SayMeyxana();
        //((Shark)animal).SayMeyxana();
    }else if (animal is Duck duck)
    {
        //Duck duck = (Duck)animal;
        duck.Quack();
    }
    //Owl owl = (Owl)animal;
    Parrot parrot = animal as Parrot;
    if (parrot != null)
    {
        parrot.Talk();
    }
}


#endregion

#region Boxing
Object num = 256;
int i = (int) num;

#endregion