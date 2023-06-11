## Proof Key for Code Exchange Nedir?


Single Page Application(SPA) ve Mobil uygulamalara client secret gibi kritik olan değerleri göndermek oldukça tehlike arz edebilmektedir. Misal, SPA’lar özünde JavaScript oldukları için, kendilerine gönderilen çoğu veriyi tarayıcıda tutmakta ve işlemlerini tarayıcılar üzerinde gerçekleştirmektedirler. Biliyorsunuz ki, tarayıcı üzerinde tutulan verilere kullanıcılar az çabayla erişebilmektedirler. Bu durumda client secret gibi önemli bir değeri tarayıcı üzerinde çalışan SPA gibi uygulamalara göndermek, kötü niyetli kişiler tarafından elde edilmesini ve türlü saldırılara yahut sızıntılara mahal verilmesini sağlayabilir. Aynı şekilde bu durum mobil uygulamalar içinde geçerlidir. Mobil uygulamalar, tersine mühendislikle çok rahat deşifre edilebilmekte ve kendilerine gönderilen kritik verileri kötü niyetli kullanıcılara ister istemez kaptırabilmektedirler.


İşte, OAuth 2.0 ve Open Id Connect protokollerini kullanırken yahut bu protokolleri benimsemiş olan IdentityServer4 gibi framework’ler de çalışırken client’a gönderilmesi gereken client secret gibi kritik değerleri mevcudiyette olan böyle bir riske karşı göndermek yerine güvenlik açısından farklı çözümler düşünülmüş ve Proff Key for Code Exchange yöntemi tasarlanmıştır.


Proff Key for Code Exchange, kod değişimi için ıspat/kanıt anahtarı şeklinde meal edilebilir. Peki bu ne demektir? PKCE, kullanıcı kimliğinin doğrulanmasını talep eden client’ın, access token elde edebilmesi için tutması gereken secret gibi kritik bilgiler yerine farklı değerler üreterek doğrulama işleminin güvenli bir şekilde yapılmasını sağlamaktadır. Server, kendisine gelen talep içerisinde kod değişimi yapılabilecek bir doğrulayıcı ile yapacağı doğrulama neticesinde güvenli bir kullanıcı doğrulaması gerçekleştirecek ve böylece kötü niyetli client’lardan korunmuş olacaktır.


Şimdi burada işlevsellik gösterecek iki aktörümüzü net tanıyalım, tanımlayalım;


code_verifier
Client tarafından yapılan access token talebi neticesinde doğrulama işlemi için kullanılan random üretilmiş bir koddur.
code_challenge
code_verifier’ı doğrulamak için client’a gönderilmiş olan random üretilmiş bir koddur.


Client, authorization code talebinde bulunduğunda öncelikle client’a ait code_challenge ve code_verifier üretilir. code_verifier authorization code ile birlikte client’a gönderilirken, code_challenge Auth Server’da bu client’a özel kaydedilir. Ardından authorization code’u alan client, access token isteğinde bulunabilmek için code_verifier‘ı da istekte gönderir. Auth Server, gelen istekteki code_verifier‘ı alır ve önceden oluşturulup ilgili client’a dair tutulan code_challenge değeri ile karşılaştırır. Eğer bu karşılaştırma neticesinde doğrulama gerçekleştirilirse client access token’ı elde eder. Böylece ilgili client, secret değeri yerine sadece code_verifier ve code_challenge değerlerini kullanmış olacaktır ve olası risk ortadan kalkacaktır.


Proof Key for Code Exchange, merkezi üyelik sistemi gerektiren–Authorization Code Grant(Flow) ve Implicit Grant(Flow)– durumlarda kullanılır. Lakin doğrulamanın merkezi olmadığı –Resource Owner Credentials Grant(Flow)– durumlarda ise kullanılmasına gerek yoktur.


## PKCE Kullanımı Nasıldır?


IdentityServer4’te PKCE kullanımı oldukça basittir. Bunun için ‘Config.cs’ dosyasında ilgili client’a dair aşağıdaki gibi ‘RequirePkce’ property’sine ‘true’ değerinin verilmesi yeterlidir.
```csharp
public static IEnumerable<Client> GetClients() =>
    new List<Client>
    {
        new Client
        {
            .
            .
            .
            RequirePkce = true
        }
    };
```
## Kaynak

https://www.gencayyildiz.com/blog/identityserver4-yazi-serisi-20-pkceproof-key-for-code-exchange

https://www.youtube.com/watch?v=_zWovo2zv6k
