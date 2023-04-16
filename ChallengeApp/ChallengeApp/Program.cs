string name = "Roland";
string age2 = "pełnoletni";
string age3 = "niepełnoletni";
bool adult = true;
int age = 20;
string resoult1 = "mam na imię";
string resoult2 = "mam";
string resoult3 = "i jestem";
string resoult4 = "i nie jestem";
char sp = ' ';




if (age >= 18)
{
    Console.WriteLine(resoult1 + sp + name + sp + resoult2 + sp + "lat" + sp + age + sp + resoult3 + sp + age2);
}
else
{
    Console.WriteLine(resoult1 + sp + name + sp + resoult2 + sp + "lat" + sp + age + sp + resoult4 + sp + age3);
}
