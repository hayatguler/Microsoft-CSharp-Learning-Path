 Contoso Petting Zoo Administration App

Bu proje, Microsoft C# Learning Path kapsamında geliştirilmiş, okul gezileri için hayvanları gruplandıran ve yöneten bir konsol uygulamasıdır.Projenin Amacı

Contoso Petting Zoo'yu ziyaret eden okullar için;

Mevcut hayvanları rastgele karıştırmak,

Okulun öğrenci sayısına göre dinamik gruplar oluşturmak,

Her gruba eşit sayıda hayvan atamak ve sonucu raporlamaktır.Kullanılan Teknolojiler ve Konseptler

Bu projede C# programlama dilinin temel ve orta seviye yapıları kullanılmıştır:

1. Algoritmalar (Fisher-Yates Shuffle)

Hayvanların her seferinde gerçekten rastgele sıralanması için In-Place Shuffle (Yerinde Karıştırma) algoritması kullanıldı.

Random sınıfı ile rastgele indeks üretildi.

Geçici bir değişken (temp) kullanılarak dizi elemanları veri kaybı olmadan takas edildi (Swap işlemi).

2. Çok Boyutlu Diziler (Multidimensional Arrays)

Veriyi organize etmek için 2 boyutlu diziler (string[,]) kullanıldı.

Satırlar: Ziyaretçi gruplarını temsil eder.

Sütunlar: O gruba atanan hayvanları temsil eder.

3. Modüler Metot Yapısı (Wrapper Methods)

Kod tekrarını önlemek (DRY Prensibi) ve okunabilirliği artırmak için PlanSchoolVisit adında bir Sarmalayıcı Metot (Wrapper) oluşturuldu. Bu metot, alt işçileri (RandomizeAnimals, AssignGroup, PrintGroup) tek bir merkezden yönetir.

4. Opsiyonel Parametreler (Optional Parameters)

Metot esnekliğini artırmak için varsayılan değerler kullanıldı:

void PlanSchoolVisit(string schoolName, int groups = 6) 


Bu sayede grup sayısı belirtilmezse, sistem otomatik olarak varsayılan değeri (6) kullanır.
