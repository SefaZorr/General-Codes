--Select
--ANSII

-- * Demek bütün kolonları alır from hangi tablodan alacagını söyler.Alyans tablonun hangi isminde gelmesini istiyorsak yazıyoruz o şekil.
Select ContactName Adi,CompanyName Sirkeadi,City Sehir from Customers  

--Where demek koşul demek.
Select * from Customers where City = 'Berlin'                          

--Sql Case insensitive büyük küçük hark duyarsızdır.
--Or demek yada demektir ikisini birlikte getiriyor.Yada iki şarttan herhangi biri geçerli olması yeterli.Ahmet veya ayşe gelsin mesela.
Select * from Products where CategoryID = 1 or CategoryID = 3

--And demek ikisini birlikte karşılayacak demektir.Ahmet ve ayşe gelsin mesela.
Select * from Products where CategoryID = 1 and UnitPrice>=10

--Mesela e-ticaret sitesinde fiyata göre sırala yada azalana göre felan dersek bu işi order by yapıyor.Default olarak asc(ascending) azdan çoga dogru sıralıyor
--tersini yapmak yani azalana göre istersek desc(descending) yaparız.Ascending artan descending düşen den geliyor ordan aklına gelsin.
select * from Products where CategoryID=1 order by UnitPrice desc


--count bize tüm satırları sayıyor sayısını veriyor.Product tablosundaki kaç data var onu veriyor mesela yönetim dediki biz katalogda kaç ürün besliyoruz bu o işi yapar.
--Buna where koşuluda ekleyebiliriz mesela categoryId 2 olanların sayısını ver gibi.
Select count(*) Adet from Products where CategoryID=2



--Yönetim dediki hangi category de kaç farklı ürünümüz var diye sordu mesela yukarıdaki 2 numaralı kategoridekini tek veriyordu ama biz tüm kategorileri ayrı ayrı istiyoruz.
--Yanına kategorilerin IDlerini ve yanına kaç tane olduklarını istiyoruz.Group by kullandıgımız zaman select ettiginiz kolon sadece group by da yazdıgınız alan olabilir.
--Group by yaptıgın zaman arka planda mesela her bir grup için bir tablo oldugunu düşünebilirsin.Group by larda koşulumuzu having ile yazıyoruz.
select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10



--Join işlemi tabloları birleştirmeye yarıyor mesela categoryId de sayı olarak degil ismini yazıcak tabloda.On durumunda şartında demek bunlar eşitse bunları yanyana getir
--demek.C# ta ilerleyen zamanlarda bunu DTO (Data Transformation Object) diyecegiz.
--Inner join sadece 2 tablodada eşleşenleri bir araya getirir eşleşmeyen data varsa onu getirmez.
Select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


--Left join solda olup sagda olmayanlarıda getir demek yani ürünler tablosunda var ama hiç satışı yok demek.
Select * from Products p  left join [Order Details] od 
on p.ProductID=od.ProductID



--Left join demek burada solda olup müşterilerde olup siparişlerde olmayanlarıda hem inner join olanları hemde müşterilerde olmayanlarıda getir demek.Bunlar sistemize kayıt
--olmuş ama alışveriş yapmamışlardır.
--Righ join sagda olup solda olmayanlarıda getir demek.
Select * from Customers c Left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null


