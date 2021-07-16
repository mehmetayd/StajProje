////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading;
////using System.Threading.Tasks;
////using Google.Apis.Auth.OAuth2;
////using Google.Apis.Calendar.v3;
////using Google.Apis.Calendar.v3.Data;
////using Google.Apis.Services;
////using Google.Apis.Util.Store;
////namespace XYZ_Projem
////{
////    class gtakvim
////    {
////        UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
////                     new ClientSecrets
////                     {
////                         ClientId = "872930902032-jtlb6jaoqkr2e74b6sgs6a7qo8b7atgc.apps.googleusercontent.com", //İstemci Kimliği
////                  ClientSecret = "AIzaSyDkM1WzXN7aBZHz1GABNBYxFl5_FtufQOU", //İstemci Gizli Anahtar
////              },
////                  new[] { CalendarService.Scope.Calendar },
////                      "gmail.com",
////                   CancellationToken.None).Result;
////        var service = new CalendarService(new BaseClientService.Initializer()
////        {
////            HttpClientInitializer = credential,
////            ApplicationName = "Uygulama Adı",
////        });;

////    Event newEvent = new Event()
////    {
////        Etkinlik Başlığı için : Summary
////        Summary = "Mehmet AYDIN - Bilgisayar Mühendisi",
////                    Etkinlik Konumu
////                    Location = "İstanbul",
////                    Etkinlik Açıklaması
////                    Description = "Bu bir örnek etkinlik açıklamasıdır.",
////                    Start = new EventDateTime()
////                    {
////                        Etkinlik Başlangıç Saati
////                        DateTime = DateTime.Now.AddMinutes(30), //Etkinlik başlangıç saatini şuanki vakitten 30 dakika sonrası için ayarlıyoruz
////                        TimeZone = "Europe/Istanbul", //Saat dilimini nereye göre alacağını belirtiyoruz.
////                    },
////                    End = new EventDateTime()
////                    {
////                        Etkinlik Bitiş saati
////                        DateTime = DateTime.Now.AddDays(1), //Etkinlik bitişini bir gün sonrası olarak belirliyoruz
////                        TimeZone = "Europe/Istanbul",
////                    },
////                    Attendees = new EventAttendee[] {
////                        Buraya hangi kişinin Takvimine ekleme yapacağımızı belirtiyoruz.Google hesabına sahip bir mail olması gerekmekte ayrıca virgül ile ayırarak birçok mail adresine ekleme yapabilirsiniz.
////                    new EventAttendee() { Email = "mehmet.ayd.3411@gmail.com"},
////                        },
////                    Reminders = new Event.RemindersData()  //Bu sınıfta hatırlatıcıları planlıyouruz.
////                    {
////                        UseDefault = false,
////                        Overrides = new EventReminder[] {
////                         new EventReminder() { Method = "email", Minutes = 24 * 60 },//Etkinliğe bir gün kala mail ile bilgilendir.
////                         new EventReminder() { Method = "popup", Minutes = 10 }, //Etkinliğie son 10 dakika kala kullanıcıya bildirim gönder.
////                }
////                    }
////                };
////        String calendarId = "primary"; // BURAYA KENDİ ID'Mİ Mİ YAZACAM !
////        EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
////        Event createdEvent = request.Execute();

////    }
////}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
namespace XYZ_Projem

{
    class takvim
    {
        UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
         new ClientSecrets
         {
             ClientId = "872930902032-jtlb6jaoqkr2e74b6sgs6a7qo8b7atgc.apps.googleusercontent.com", //İstemci Kimliği
                  ClientSecret = "AIzaSyDkM1WzXN7aBZHz1GABNBYxFl5_FtufQOU", //İstemci Gizli Anahtar
              },
      new[] { CalendarService.Scope.Calendar },
          "gmail.com",
       CancellationToken.None).Result;
     
        Event newEvent = new Event()
    {
       // Etkinlik Başlığı için : Summary
        Summary = "Mehmet AYDIN - Bilgisayar Mühendisi",
                    //Etkinlik Konumu
                    Location = "İstanbul",
                    //Etkinlik Açıklaması
                    Description = "Bu bir örnek etkinlik açıklamasıdır.",
                    Start = new EventDateTime()
                    {
                    //    Etkinlik Başlangıç Saati
                        DateTime = DateTime.Now.AddMinutes(30), //Etkinlik başlangıç saatini şuanki vakitten 30 dakika sonrası için ayarlıyoruz
                        TimeZone = "Europe/Istanbul", //Saat dilimini nereye göre alacağını belirtiyoruz.
                    },
                    End = new EventDateTime()
                    {
                     //   Etkinlik Bitiş saati
                        DateTime = DateTime.Now.AddDays(1), //Etkinlik bitişini bir gün sonrası olarak belirliyoruz
                        TimeZone = "Europe/Istanbul",
                    },
                    Attendees = new EventAttendee[] {
                     //   Buraya hangi kişinin Takvimine ekleme yapacağımızı belirtiyoruz.Google hesabına sahip bir mail olması gerekmekte ayrıca virgül ile ayırarak birçok mail adresine ekleme yapabilirsiniz.
                    new EventAttendee() { Email = "mehmet.ayd.3411@gmail.com"},
                        },
                    Reminders = new Event.RemindersData()  //Bu sınıfta hatırlatıcıları planlıyouruz.
                    {
                        UseDefault = false,
                        Overrides = new EventReminder[] {
                         new EventReminder() { Method = "email", Minutes = 24 * 60 },//Etkinliğe bir gün kala mail ile bilgilendir.
                         new EventReminder() { Method = "popup", Minutes = 10 }, //Etkinliğie son 10 dakika kala kullanıcıya bildirim gönder.
                }
                    }
                };

        String calendarId = "primary";
        EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
        Event createdEvent = request.Execute();
    }

}