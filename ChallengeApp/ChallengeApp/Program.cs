string imie = "Roland";
string wiek = "pełnoletni";
string wiek1 = "niepełnoletni";
bool adult = true;
int age = 20;
string resoult1 = "mam na imię";
string resoult2 = "mam";
string resoult3 = "i jestem";
string resoult4 = "i nie jestem";
char sp = ' ';




if (age >= 18)
{
    Console.WriteLine(resoult1 + sp + imie + sp + resoult2 + sp + "lat" + sp + age + sp + resoult3 + sp + wiek);
}
else
{
    Console.WriteLine(resoult1 + sp + imie + sp + resoult2 + sp + "lat" + sp + age + sp + resoult4 + sp + wiek1);
}
