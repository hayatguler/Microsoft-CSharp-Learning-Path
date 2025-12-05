Console Adventure Mini Game

Bu proje, Microsoft C# Learning Path kapsamında geliştirilmiş, etkileşimli bir konsol oyunudur. Oyuncu karakteri kontrol ederek yiyecekleri toplar ve yediği yiyeceğe göre özel güçler kazanır.
Güçlendirmeler (Power-ups) & Etkileri

| Yiyecek | Görünüm | Etki |
| :---: | :---: | :--- |
| `@@@@@` | `('-')` | **Normal:** Standart hızda hareket edersiniz. |
| `$$$$$` | `(^-^)` | **Hızlanma:** Karakteriniz **3 kat** daha hızlı hareket eder! |
| `#####` | `(X_X)` | **Donma:** Karakteriniz zehirlenir ve **1 saniye** boyunca hareket edemez.|
### 1. Oyun Döngüsü (Game Loop)
Oyun, `while (!shouldExit)` döngüsü içinde sürekli çalışır ve her karede (frame) durumu günceller.

### 2. Durum Yönetimi (State Management)
Karakterin o anki durumunu (Donmuş, Hızlı, Normal) kontrol etmek için boolean metotlar (`ShouldFreeze`, `ShouldSpeedUp`) kullanıldı.

### 3. Çarpışma Algılama (Collision Detection)
Karakterin ve yiyeceğin (X, Y) koordinatları sürekli karşılaştırılarak yeme işlemi algılandı.

### 4. Opsiyonel Parametreler (Optional Parameters)
Metotları esnek hale getirmek için:
```csharp
void Move(int speed = 1, bool terminateOnNonDirectional = false)
