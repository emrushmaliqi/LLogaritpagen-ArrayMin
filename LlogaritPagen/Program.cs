using LlogaritPagen;

#region ArrayMin exercise

var arrayMin = new ArrayMin();

arrayMin.InitializeArray();

arrayMin.InsertNumbers();

int minValue = 0;

try
{
    minValue = arrayMin.Min();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Smallest number is: {minValue}");



#endregion

Console.WriteLine("--------------------------------------------------------------------------------");

#region LlogaritPagen exercise

Zhvillues zhvillues = new(321,"Zhvilluesi", "zhvillues", 89000);

Menaxher menaxher = new(111, "Menaxheri", "menaxher", 268000);

Admin admin = new(123, "Admini", "admin", 320042);

Console.WriteLine($"ID: {zhvillues.Id}, Emri: {zhvillues.Emri}, Pozita: {zhvillues.Pozita}, Rroga: {zhvillues.Rroga}, Bonusi: {zhvillues.CalculateBonus(zhvillues.Rroga)}");
Console.WriteLine($"ID: {menaxher.Id}, Emri: {menaxher.Emri}, Pozita: {menaxher.Pozita}, Rroga: {menaxher.Rroga}, Bonusi: {menaxher.CalculateBonus(menaxher.Rroga)}");
Console.WriteLine($"ID: {admin.Id}, Emri: {admin.Emri}, Pozita: {admin.Pozita}, Rroga: {admin.Rroga}, Bonusi: {admin.CalculateBonus(admin.Rroga)}");

#endregion