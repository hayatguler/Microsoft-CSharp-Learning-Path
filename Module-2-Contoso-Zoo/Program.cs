using System;

// H A M M A D D E (Veri Kaynağı)
string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// --- ANA PROGRAM AKIŞI ---

// Okul A: Varsayılan grup sayısı (6) kullanılır.
PlanSchoolVisit("School A");

// Okul B: 3 Grup istenir.
PlanSchoolVisit("School B", 3);

// Okul C: 2 Grup istenir.
PlanSchoolVisit("School C", 2);

// --- METOTLAR (İŞÇİLER) ---

// 1. ORKESTRA ŞEFİ (Wrapper Method)
// Tüm süreci tek elden yönetir.
void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals(); // Önce karıştır (Her okul için yeni karışım!)
    string[,] group = AssignGroup(groups); // Sonra grupla
    
    Console.WriteLine(schoolName); // Başlığı at
    PrintGroup(group); // Yazdır
    Console.WriteLine(); // Okullar arasına boşluk bırak
}

// 2. KARIŞTIRICI (Fisher-Yates Shuffle)
void RandomizeAnimals() 
{
    Random random = new Random();
    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);
        
        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

// 3. GRUPLAYICI (2D Array Creator)
string[,] AssignGroup(int groups = 6) 
{
    // Tablo Boyutu: [Grup Sayısı, Grup Başına Düşen Hayvan]
    string[,] result = new string[groups, pettingZoo.Length/groups];
    
    int start = 0; // Ana listeden çekmek için işaretçi

    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i,j] = pettingZoo[start++];
        }
    }

    return result;
}

// 4. YAZICI (UI Display)
void PrintGroup(string[,] groups) 
{
    for (int i = 0; i < groups.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++) 
        {
            // PadRight(10) metni hizalamak için ekstra bir dokunuş (Opsiyonel ama şık durur)
            Console.Write($"{groups[i,j]}  ");
        }
        Console.WriteLine();
    }
}
