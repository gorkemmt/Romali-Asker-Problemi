# Romalı Asker Problemi Çözümü

# Uygulama Amacı:
- Bir miktar askerin birbirini öldürmesi gerektiği durumu varsayılarak bu durum bir algortima kullanılarak birbirlerini öldürma sıralarını hesaplıyoruz.Algoritmaya göre ilerlenip son adımda 2 askerin hayatta kalması ve onların birbirlerini aynı anda öldürmesi gerekiyor. Bu yazılan uygulamanın amacı bu durumu bilgisayar üzerinde simüle ederek hangi asker sayısı ve atlama sayısına göre son iki hayatta kalan askerin numaraları öğrenmek.

# Kullanılan Girdiler Ve Nedenleri:
 1-Kaç asker arasında işlem yapılacağını öğrenmek için toplam asker sayısı.
 2-Algoritmanın atlama miktarı için ise sayma sayısı bilgileri kullanıcıdan alınmıştır.

# Problemin Çözüm Mantığı:
- Girilen asker sayısına göre bir dizi oluşturup askerlerin hayatta olma durumlarını orada tuttuk. Bu işlemden sonra son iki asker hayatta kalana kadar çalışacak bir döngü oluşturduk ve bu döngü içerisinde girilmiş olan sayma sayısına göre hayatta olan askerler arasında ilerleyip sırası gelen askerlerin yaşam durumunu dizi içerisinde 0 olarak değiştirdik. Son iki asker kaldığı zaman döngüden çıkmasını ve kalan askerlerin sıra numaralarını ekrana yazdırmasını sağladık.

# Çalıma Örnek Gösterimi:
![romalı asker](https://user-images.githubusercontent.com/84309668/183265717-06df6eb7-8bd2-45da-9c66-798938b36f3e.png)


# Örnek Test Case Tablosu:
![test case](https://user-images.githubusercontent.com/84309668/183265718-0f063853-5d53-422f-bb77-1d108486512b.PNG)




