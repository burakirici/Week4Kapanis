Teknoloji Mağazası Ürün Kayıt Sistemi,
Bu proje, bir teknoloji mağazasında Telefon ve Bilgisayar kayıtlarını almak için geliştirilmiştir. Kullanıcı, Telefon veya Bilgisayar ürünü oluşturabilir ve bu ürünlerin bilgilerini konsol ekranında görüntüleyebilir.

Proje Özellikleri
Inheritance (Miras)
Proje, BaseMakine adında bir Base Class (temel sınıf) içerir ve bu sınıftan Telefon ve Bilgisayar sınıfları türetilmiştir. BaseMakine sınıfı ortak özellikler olan Üretim Tarihi, Seri Numarası, Ad, Açıklama ve İşletim Sistemi bilgilerini içerir.

Encapsulation (Kapsülleme)
Bilgisayar sınıfında Usb giriş sayısı sadece 2 veya 4 olarak ayarlanabilir. Eğer bu değerler dışında bir sayı girilirse, uyarı mesajı verilir ve usb giriş sayısı -1 olarak ayarlanır.
Telefon ve Bilgisayar sınıflarında Üretim Tarihi, nesne oluşturulduğu anda otomatik olarak atanır.
Polymorphism (Çok Biçimlilik)
BaseMakine sınıfında ortak bilgileri yazdıran bir BilgileriYazdir() metodu bulunur. Derived class'lar (Telefon ve Bilgisayar), bu metodu ezerek kendi özelliklerini eklerler.

Abstraction (Soyutlama)
UrunAdiGetir() adında abstract bir metot tanımlanmış olup, Telefon ve Bilgisayar sınıflarında ezilerek:

"Telefonunuzun adı ---> [Telefon Adı]"
"Bilgisayarınızın adı ---> [Bilgisayar Adı]"
mesajları konsola yazdırılır.
Program Akışı
Kullanıcıdan Telefon üretmek için 1, Bilgisayar üretmek için 2 tuşlaması istenir.
Kullanıcının seçimine göre ilgili sınıftan bir nesne üretilir ve ürün bilgileri kullanıcıdan konsol ekranı üzerinden alınır.
Tüm bilgiler girildiğinde, ürün başarıyla üretildiğine dair bir mesaj gösterilir.
Kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur. Evet cevabı verilirse 1. adıma dönülür, hayır cevabı verilirse "İyi günler!" mesajı ile program sonlanır.
Nasıl Çalıştırılır
Projeyi başlatın.
Konsol ekranında gelen seçeneklere göre Telefon ya da Bilgisayar üretimini seçin.
Ürün bilgilerini girin.
Ürünün başarıyla oluşturulmasını izleyin.
Başka bir ürün üretmek isteyip istemediğinizi seçin.
