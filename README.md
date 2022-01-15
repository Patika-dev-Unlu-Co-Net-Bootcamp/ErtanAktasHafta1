# ErtanAktasHafta1 Ödev
Proje kapsamında bir task manager uygulaması tasarlanmıştır ve bu uygulama ile task ekleme filtreleme silme güncelleme listeleme işlemleri yapılmıştır.

## Api Listesi ve kullanımları

### Get
*http://localhost:5000/api/Task* Bütün taskları Tarihe göre en önce olarak şekilde listeler.

### Get By Status
*http://localhost:5000/api/Task/Aktif* - *http://localhost:5000/api/Task/Pasif*

Taskları Aktif ve ya pasif olma duruma göre getirir.

### Get Search 
*http://localhost:5000/api/Task/search?search=test*

Girilen kelimeye göre task başlıklarında arama yapılır ve sonuçlar listelenir.

### Post 
*http://localhost:5000/api/Task*
Yeni task eklemek için body içine eklenen bilgiler ile doldurulur.
<br />

```
  {
  "id": 6,
  "title": "Yeni Task",
  "description": "Task Açıklaması",
  "status": "Aktif",
  "date": "2022-01-19T00:25:27.875Z"
  }
```
### Patch
*http://localhost:5000/TaskStatus/4*
Tskların Durumlarını Aktif veya Pasif durumlarını düzenlemek için kullnaılır Body içine Aktif-Pasif yazarak kontrol edilebilir.

### Put
*http://localhost:5000/api/Task*
Body içine girilen parametlerde eğer girilen id var olan kayıtlar ile eşleşirse var olan kaydı yeni bilgiler ile düzenler.

### Delete
*http://localhost:5000/api/Task/3*
Girilen id ile eşleşen kayıdı siler.





