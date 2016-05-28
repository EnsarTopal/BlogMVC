using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMVC.Context
{
    public class BlogInıtializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            #region CategoryList
            List<Entity.Category> categorylist = new List<Entity.Category>()
            {
                new Entity.Category() { Name="Yaşam" },
                new Entity.Category() { Name="Sağlık" },
                new Entity.Category() { Name="Teknoloji" },
                new Entity.Category() { Name="Aşk-Meşk" },
                new Entity.Category() { Name="Din" },
                new Entity.Category() { Name="Sistem Eleştirileri" },
            };
            foreach (var category in categorylist)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();
            #endregion

            #region AuthorList
            List<Entity.Author> AuthorList = new List<Entity.Author>()
            {
                new Entity.Author() {Name="Ensar",Surname="Topal" },
                new Entity.Author() {Name="Mahmut",Surname="Tuncer" },
                new Entity.Author() {Name="Ulaş",Surname="Toluay" },
                new Entity.Author() {Name="Hakan",Surname="Ünal" },
                new Entity.Author() {Name="Erkan",Surname="Öztekin" },
                new Entity.Author() {Name="Onur",Surname="Yanmış" },
                new Entity.Author() {Name="Yasin",Surname="Kır" },
                new Entity.Author() {Name="Doğukan",Surname="Koçak" },
                new Entity.Author() {Name="Çetin",Surname="Çıplak" },
                new Entity.Author() {Name="Uğurcan",Surname="Uyan" },
                new Entity.Author() {Name="Melis",Surname="Turan" },
                new Entity.Author() {Name="Şeyda",Surname="Ay" },
            };
            foreach (var author in AuthorList)
            {
                context.Authors.Add(author);
            }
            context.SaveChanges();
            #endregion

            #region BlogList
            List<Entity.Blog> bloglist = new List<Entity.Blog>() {
                new Entity.Blog()
                {
                    Title="Okumanın Önemi",
                    Description="Kitap, kırılgan bir yaratıktır, zamandan etkilenir, kemirgenlerden korkar, yabancı maddelerden ve sakar ellerden de. Bu yüzden kütüphaneciler kitapları sadece insanlara karşı değil aynı zamanda doğaya karşı da korur ve hayatını unutulmanın kuvvetlerine karşı savaşmaya adar.",
                    Detail="Kitap, kırılgan bir yaratıktır, zamandan etkilenir, kemirgenlerden korkar, yabancı maddelerden ve sakar ellerden de. Bu yüzden kütüphaneciler kitapları sadece insanlara karşı değil aynı zamanda doğaya karşı da korur ve hayatını unutulmanın kuvvetlerine karşı savaşmaya adar.O altın üniversite yıllarını hatırlayın, kitaplarla dolu okul çantası, öğrenilecek birçok şey, bir sürü bilgi – tarih, coğrafya, matematik, fen. Küçük omuzlarda bilgi dolu çantaların taşındığı ve her şeye güldüğümüz zamanlar. Evet, bütün o şeyler bizi şimdi de güldürür. Eğer omuzlarımızda o ağır yükleri taşımasaydık eminim ki bugün toplumda durduğumuz yerde duruyor olamayacaktık. Bugünkü bilgimizi sadece kitaplara borçluyuz. İnternet diye bir teknolojinin var olmadığı günlerdi ve o zamanlar kitaplar, bilgiyi yaymanın tek yoluydu. Yazarlar kendi duygularını aktarırlardı; uzmanlar bilgilerini gelecek nesillerle paylaşırlardı ve bunlar sadece kitaplar aracılığıyla yapılırdı.Bu yüzden kitaplar bize atalarımızın hediyesi gibidir, bilmediğimiz birçok şeyi bize öğreten, mesela – Ramayana’nın hikayesi, Tulsidass tarafından yazılmış bir kitap.Kitaplar başarıya ulaşmak için gidilen yolda en iyi iz sürücülerdir. İlerlemiş teknoloji yüzünden kitapların şimdiki nesle olan önemi neredeyse sıfırdır. Gelişmiş teknolojinin iyi bir şey olmadığını söylemiyorum, ama yazılmış kelimelere inanmalıyız. Biliriz ki eski iyidir. Yazmayı bilmeyen zavallı bir çocuk, kitapların gerçek önemini bilen gerçek kişidir. Kitaplara hak ettikleri önemi vermek çok önemlidir.Okumak, zihnimizi rahatlatan en iyi şeydir.Tatlı hikayeler, komik fıkralar, gerçek hikayeler okuyabilirsiniz; bu size kalmış bir şeydir, ne isterseniz onu okursunuz. Çeşitli insanlar için çeşitli kitaplar mevcuttur. Bugünlerde kitapları kolay ve ucuz yoldan kapınıza ulaştıracak kaynaklar var, mesela, siteleri ziyaret ederek çok kolay bir şekilde kitap siparişi verebilirsiniz.Kitap klüplerinden birini biliyorum mesela India Today Book Club, siz üye olduktan sonra siparişlerinizi alıyor. Ondan sonra kurgu, klasik, sanat ve referans kitapları, çocuk okuma kitapları, yemek, bahçe, spor ve sağlık, din, bilişim teknolojisi, tıp ve daha birçok alandan kendi zevkinize göre sayısız kitap siparişi verebilirsiniz, üstelik büyük indirimler ve tatil paketleri gibi heyecan verici hediyelerle.İnanıyorum ki başarı pudingini tatmak için içinizde bir merak varsa kitapların fiyatı sizin için hiçbir şeydir. Ben kitap okurken kendimi daha az yalnız hissederim.",
                    Image="1.jpg",
                    PublishDate=DateTime.Now,
                    isPopular=true,
                    isPublish=false,
                    category=context.Categories.Where(i=>i.Id==1).FirstOrDefault(),
                    author=context.Authors.Where(i=>i.Id==1).FirstOrDefault()

                },
                new Entity.Blog()
                {
                    Title = "Okuma Zorlukları",
                    Description = "Bazı insanlar okumakta zorluk çeker. Bu durum yaşa bağlı değildir. Nedenleri arasında sağlık sorunları, işitme, özellikle de görme bozuklukları sayılabilir. Bazen de çocuklar okulda iyi öğretilmediği için okuma öğrenemez. Küçüklüklerinde durmadan evden eve taşınan ailelerin çocukları değişik okullara uyum sağlamakta güçlük çekebilir, bu yüzden iyi okuyamayabilirler.",
                    Detail="Bazı insanlar okumakta zorluk çeker. Bu durum yaşa bağlı değildir. Nedenleri arasında sağlık sorunları, işitme, özellikle de görme bozuklukları sayılabilir. Bazen de çocuklar okulda iyi öğretilmediği için okuma öğrenemez. Küçüklüklerinde durmadan evden eve taşınan ailelerin çocukları değişik okullara uyum sağlamakta güçlük çekebilir, bu yüzden iyi okuyamayabilirler. Ayrıca bazı çocuklar okumaktan hoşlanmayabilir, başka şeylerle uğraşmak onları daha mutlu edebilir. Okuma öğrenmekte güçlük çeken çocuklara yardımcı olmak için eğitilmiş özel öğretmenler vardır. Bunlar çocuğun neden yaşıtları gibi öğrenemediğini testler uygulayarak araştırır. Sorunun ne olduğu bir kez saptanınca, çocuğun özel eğitimle okuma öğrenmesi kolaylaşır.Basit bir bedensel bozukluktan kaynaklandığı sanılan disleksi okumayı öğrenme güçlüğü olarak tanımlanabilir. Normal yaşta okula başlamış, zeka geriliği ya da davranış bozukluğu olmayan bazı çocuklar akıcı bir biçimde okumayı başaramaz ya da söylenişi ve yazılışı yakın harfleri birbirine karıştırır. Örneğin, disleksililer “ya” yı “ay” ya da “d” yi “b” olarak okur. Disleksinin çeşitli dereceleri vardır.çabuk farkına varılması durumunda bazen özel eğitimle okuma öğretilse de, disleksinin nedenlerine ilişkin kesin bir bulgu yoktur. Disleksililer okuma eksikliklerini görsel ve işitsel gereçlerle bir ölçüde giderebilmektedir.Annelerin, babaların, öğretmenlerin ilk amacı, çocuğu sadece okul sıralarında değil, ömrü boyunca okumaktan zevk alacak bir kişi olarak yetiştirmek olmalıdır. Yalnızca güzel okumanın yeterli olmayacağı, okumanın yaşamın vazgeçilmez, verimli bir uğraşı olduğu bilinci çocuklara aşılanmalıdır. Böylesi bir özendirmeyle çocuklara koskoca bir kitap ve bilgi dünyasının kapıları açılmış olur.",
                    Image="2.jpg",
                    PublishDate=DateTime.Now,
                    isPopular=true,
                    isPublish=true,
                    category=context.Categories.Where(i=>i.Id==2).FirstOrDefault(),
                    author =context.Authors.Where(i=>i.Id==2).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="Bilgisayar Zararlı Mı?",
                    Description="Son günlerde bilim adamları(Bazıları) ilerki yıllarda,insan zekasının geriliyeceğini iddaa ediyor. Gerekceleri ise tek şuçlu olarak bilgisayar`ı gösteriyorlar.",
                    Detail="Son günlerde bilim adamları(Bazıları) ilerki yıllarda,insan zekasının geriliyeceğini iddaa ediyor. Gerekceleri ise tek şuçlu olarak bilgisayar`ı gösteriyorlar. Hepimizin bildiği gibi beyin cimnastiki dediğimiz bir olay var. Beynimizi ne kadar zorlarsak, o kadar gelişmesine ve genç kalmasına katkıda bulunuyoruz… Bunlardan en basiti bulmaca çözmek gibi. Şimdi acaba şöyle bir kolaycılığa kaçıyormuyuz ,veya zamanla kaçacakmıyız?Bu kolaycılığın doğal sonucu olarakta gelecek kuşaklarda IQ`muzda bir düşme olacak mı? Bir arkadaşınız sizden bir konu hakkında bilgi almak istiyor,veya çoçuğumuzun takıldığı bir dersten dolayı,size birşey sorma isteği duyduğun da,onlara vereceğimiz cevap: Bana sormana ve düşünmene artık gerek yok . Gir bilgisayara ne sormak veya öğrenmek istiyorsan,yaz ve tıkla bu kadar basit hemen karşına çıkar. Bu örneklerin sonunda bilim adamlarının endişeleri acaba haklı çıkar mı?",
                    Image="3.jpg",
                    PublishDate=DateTime.Now.AddHours(-2),
                    isPopular=true,
                    isPublish=true,
                    category=context.Categories.Where(i=>i.Id==3).FirstOrDefault(),
                  author=context.Authors.Where(i=>i.Id==3).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="Kalbin Emeği",
                    Description="Dua kalbin emeğidir. Kalpten gelen arzuları ifade eder. Ancak insanın bu arzuların üzerinde bir gücü yoktur. İnsan öyle bir şekilde yaratılmıştır ki insan tam olarak ne aradığını ya da gerçek niyetinin ne olduğunu bilmez. ",
                    Detail="Dua kalbin emeğidir. Kalpten gelen arzuları ifade eder. Ancak insanın bu arzuların üzerinde bir gücü yoktur. İnsan öyle bir şekilde yaratılmıştır ki insan tam olarak ne aradığını ya da gerçek niyetinin ne olduğunu bilmez. Dolayısıyla dualarının önem teşkil eden doğasını da anlayamamaktadır. Buna karşılık, dua kitaplarında yazanlar aslında kişinin istemesi gerekenleri öğrenmesini anlatan şeylerdir. Eğer kişi kendisi üzerinde çalışırsa ve arzu ve düşüncelerini kontrol edip yönlendirme yolunda çalışırsa, dua kitaplarını yazan insanların arzu ve talep seviyelerine yükselir. Dua kitapları maneviyatı edinmiş insanlar tarafından binlerce yıl önce yazılmıştır. Kişinin dua kitaplarını yazan kişiler ile arzularını uyumlu hale getirebilmesi için birkaç hazırlık safhasından geçmesi gereklidir. Kişi kötülüğün doğasını ve nelere sebep olduğunu anlaması gerekir, şöyle ki, insanın doğası gereği egoist bir eğilimi olduğudur. Kişi egoizminin (benliğinin) kötülüğün kaynağı olduğunu anlamalıdır. Hatta dahası, bunların hepsinin ruhun en derin noktasında edinilmesi ve fark edilmesi gerekmektedir.",
                    Image="4.jpg",
                    PublishDate=DateTime.Now,
                    isPopular=true,
                    isPublish=false,
                    category=context.Categories.Where(i=>i.Id==4).FirstOrDefault(),
                    author=context.Authors.Where(i=>i.Id==4).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="Çocuklarınıza Zaman Ayırın",
                    Description="Çocukları televizyon bağımlılığından kurtarmanın tek çaresi onlara zaman ayırmaktır. Anne baba olarak öncelikli görevimiz çocuklarımıza iyi bir eğitim kazandırmaktır. Hiçbir işimiz çocuk eğitiminden daha önemli değildir.",
                    Detail="Çocukları televizyon bağımlılığından kurtarmanın tek çaresi onlara zaman ayırmaktır. Anne baba olarak öncelikli görevimiz çocuklarımıza iyi bir eğitim kazandırmaktır. Hiçbir işimiz çocuk eğitiminden daha önemli değildir. Eğer çocukların yapmaktan zevk alacakları müzik, resim, spor, kitap okumak gibi faydalı bir becerileri yoksa; anne babaların televizyonu yasaklamaları problemi çözmeyecek, daha da ağırlaştıracaktır. Çocuğunun inatçılığından, söz dinlememesinden, aşırı televizyon izlemesinden ve okuldaki başarısızlığından yakınan bir babaya “çocuğunuza zaman ayırın” tavsiyesinde bulunduğumuzda, “her akşam en az bir saat beraber ders çalışıyoruz, ödevlerine yardım ediyorum, ama değişen bir şey yok” demişti. Gülerek: “Hayır, dedim, bizim kastettiğimiz beraberlik bu değil.Çocuk bu beraberlikten zevk almaz, aksine bir an önce bitmesini ister. Siz çocuğunuza zaman ayırmıyorsunuz, ona ders çalıştırıyorsunuz.” Çocuğunuza ayırdığınız zamanın süresi değil, kalitesi önemlidir. Eğer bu beraberlikten iki taraf da zevk alıyorsa, kaliteli bir beraberlik var demektir. Birlikte yürüyüşe çıkmak, çocuk parkına gitmek, piknik yapmak, akşam yemeğinden sonra ailece çaylı-pastalı sohbet etmek, birlikte televizyonda kaliteli bir film veya program izlemek, uyku saatinde çocuğunuza masal veya kısa bir hikaye okumak ilk anda aklımıza gelebilen kaliteli beraberliklerdir. Çocuğunuzla birlikte iken iyi bir dinleyici olmalısınız.Çocuk duygularını, hayallerini, düşüncelerini, endişelerini, korkularını çekinmeden dile getirmeli ve sizinle paylaşmalıdır. Çocuklarını dinlemeyen anne babalar onları tanımakta güçlük çekerler. Çocuğunuzu ne kadar çok tanırsanız, yetenekleri konusunda beklentileriniz o kadar gerçekçi olur.",
                    Image ="tembel-yonetici.jpg",
                    PublishDate=DateTime.Now.AddDays(-1).AddHours(-3),
                    isPopular=true,
                    isPublish=true,
                    category=context.Categories.Where(i=>i.Id==2).FirstOrDefault(),
                    author=context.Authors.Where(i=>i.Id==5).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="Eğitim Köleleştiriyor mu…",
                    Description="Yıllar önce o zamanlar çok popüler bir haftalık dergi olan Nokta İstanbul’da ilginç bir deney yapmıştı. Bir tiyatro sanatçısı olan Ezel Akay eline bir megafon alarak koyu renk elbiseler ve siyah pardesüler giyen ekibiyle birlikte önce güvercinleriyle ünlü Yenicamii’nin arkasındaki parka giderler.",
                    Detail ="Yıllar önce o zamanlar çok popüler bir haftalık dergi olan Nokta İstanbul’da ilginç bir deney yapmıştı. Bir tiyatro sanatçısı olan Ezel Akay eline bir megafon alarak koyu renk elbiseler ve siyah pardesüler giyen ekibiyle birlikte önce güvercinleriyle ünlü Yenicamii’nin arkasındaki parka giderler. Parkta oturan gezen etrafı seyreden bir sürü insan vardı. Akay elindeki megafonla kalabalığa doğru sert bir emir verir: “Herkes ayağa kalksın!” Emri duyan Akay’ı ve ekibini gören istisnasız herkes derhal ayağa kalkar. Sonra Eminönü İskelesi’ne geçerler. Akay yine sert bir emirle: “Herkes yere çöksün!” diye bağırır. Gemiden inenler bilet kuyruğunda bekleyenler simitçiler işportacılar emri duyan herkes yere çöker. Sonra Mecidiyeköy’deki stadyumun önüne giderler. Megafondan: “Herkes ellirini kaldırıp duvara yaslansın!” emri duyuldu. Stadyuma girmek için kuyrukta bekleyen futbol seyircileri kokoreççiler bayrakçılar derhal emre uyarlar. Daha sonra da ekip bir fabrikanın önüne giderler. Mesai saati başlamak üzeredir. Fabrikanın girişine bir masa koyarlar ve masanın üzerinde düzmece bir evrak yerleştirerek işçilere emiri verirler: “Herkes içeriye girerken bu kâğıtlara parmak basacak!” Giren basar giren basar. Kimsenin aklına “siz kimsiniz hemşehrim? Neden bu kâğıtlara parmak basıyoruz?” diye sormak gelmez. Son olarak da Beyoğlu’na gelirler. İstiklal Caddesinde gezinen vitrinleri seyreden kalabalığa yine sert bir emir verilir: “Herkes sıraya girsin arama var!” Emri duyan herkes koyun sürüsü gibi sessizce sıraya girer.Ancak caddede dolaşan bir çift bu emre uymaz. Ekiptekilerden biri onlara doğru bağırır: “Hey siz ikiniz!Emri duymadınız mı?” Kendilerine seslenildiğini anlayan ve herkesin sıraya girdiğini gören adam cevap verir: “Who are you? What is happening here ?” Sıraya girenler içerisindeki kravatlı takım elbiseli bir bey ekibe yardımcı olmanın verdiği gurur ve heyecanla lafa karışır: “Adam turist İngilizce konuşuyor.” Ekip elemanı gülmemek için kendisini zor tutar: “Ne diyor peki ?” “Siz kimsiniz burada neler oluyor ?”  Ve o iki turistin haricinde hiç kimse neler olup bittiğini kendilerine böyle gün ortasında emirler yağdırıp sıraya sokanların kim olduğunu sormaz ya da soramaz.",
                    Image ="6.jpg",
                    PublishDate=DateTime.Now.AddHours(+8),
                    isPopular=true,
                    isPublish=false,
                    category=context.Categories.Where(i=>i.Id==6).FirstOrDefault(),
                   author=context.Authors.Where(i=>i.Id==6).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="İnsanlar",
                    Description="İnsan sinirlenir. İnsan kırıp dökmek ister. Uğraşıp emek verdiği halde, gerçekleşmeyen hayalleri gelir aklına. Kaybettiklerini, başaramadıklarını düşünür ve kahreder yaşamına. Kimi sessiz… Kimi haykırarak...  Bazıları ise, boş vermeyi tercih eder. Yansa dünya umurunda değildir. Ne gam ne keder vardır hayatında.",
                    Detail="İnsan sinirlenir. İnsan kırıp dökmek ister. Uğraşıp emek verdiği halde, gerçekleşmeyen hayalleri gelir aklına. Kaybettiklerini, başaramadıklarını düşünür ve kahreder yaşamına. Kimi sessiz… Kimi haykırarak...   Bazıları ise, boş vermeyi tercih eder. Yansa dünya umurunda değildir. Ne gam ne keder vardır hayatında.  İnsan gözyaşı döker; bazen sevinçten bazen hüzünden.  Bazıları bilmez ağlamayı; öylesine derinden hissettiği hisleri yoktur çünkü.  İnsan yorulur; hayatın yükünü üstlendiğinde.Nefes almak için kısa bir mola ister hayatından.  Kimisi ise, yaşamını hızla tamamlamak ister dur durak bilmeden.  Kalabalıklar içinde olmak ister insan; yalnızlığını unutmak için.  Kimisi ise, kendisiyle baş başa kalmak ister; ya da sevdiği birkaç kişiyle.  Kimisi aşkla yaşar kimisi nefretle..  Kimisi korkularıyla uyur, kimisi huzurla...  Kimisi yerde arar mutluluğu kimisi gökte...  Benzemez ki kimse kimseye...  Kibarı da var kabası da, yalancısı da var dürüstü de, zengini de var fakiri de, duygusalı da var hissizi de, cahili de var bilgini de, miskini de var çalışkanı da, oralısı da var buralısı da...  Çeşit çeşit insan var; siyahı da var beyazı da...",
                    Image="insanlar.jpg",
                    PublishDate=DateTime.Now,
                    isPopular=true,
                    isPublish=true,
                    category=context.Categories.Where(i=>i.Id==2).FirstOrDefault(),
                   author=context.Authors.Where(i=>i.Id==7).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="Kitabın Önemi",
                    Description="Kültürlü insanların en büyük dostu, yardımcısı ve eğlencesi kitaptır. Kitap, zihnimizin ve gönlümüzün ihtiyaçlarını en kestirme yoldan karşılayan kıymetli bir hazinedir. Dimağımızı çalıştıran, hayal gücü sınırlarını genişleten sihirli bir etkisi vardır. ",
                    Detail="Kültürlü insanların en büyük dostu, yardımcısı ve eğlencesi kitaptır. Kitap, zihnimizin ve gönlümüzün ihtiyaçlarını en kestirme yoldan karşılayan kıymetli bir hazinedir. Dimağımızı çalıştıran, hayal gücü sınırlarını genişleten sihirli bir etkisi vardır.  Kitap okumanın zevkine bir kere eriştik mi bir daha kitapsız edemeyiz. Artık o, bizim her yerde sadık kılavuzumuz olur. Herhangi bir konuda geniş bilgi edinmek, evrenin sırlarını çözmek istiyorsak hemen ona el atarız. İnsanlardan sıyrılıp kendi kabuğumuza çekildiğimiz zaman da, türlü bunalımlarla gerilen ruhumuzu avutmak için yine onu yanımıza alırız. Her kitap yeni bir ülkenin fethedilmesigibi bize birçok şey kazandırır. Görüş dünyamız genişler; gördüklerimizin bilincine varırız.Duyarlılığımız gelişir, duyduklarımız -yere ve zamana uygun - akisler uyandırır zihnimizde. Bir şeyi anlamakta ve anlayışımıza göre hareket etmekte güçlük çekmeyiz. Kitap sayfalarındaki o cansız gibi görünen sözcükler öyle bir kudrete sahiptir ki, zamanla sözcük dağarcığımızda birikerek güzel ve kolay konuşabilme niteliğini kazanmamızı sağlar. Sözün kısası, kitaplar duyularımıza,görüşlerimize, hareketlerimize aklın ve düşüncenin kılavuzluğunu sağlar.  Okuma zevkinden yoksun olan insanlar ne yazık ki karanlık bir dünyada yaşıyor gibidirler.Bu insanların fikirleri ve konuşmaları basit bir düzeyde kalır.İstediklerini etkili ve güzel bir şekilde anlatamazlar.Hayalleri donuk ve kısırdır; çekici bir yanları bulunmaz. Yüksek fikirleri anlamakta güçlük çekerler.Aydın kişilerin arasına girdikleri zaman varlıklarını duyuramazlar.Derinlikleri yoktur. Duygularını bile yerine göre kullanamazlar.  Aydın insanlar grubuna girmek, sağlam bir kişiliğe sahip seçkin bir insan olmak, görüş ve anlayış kudreti, güzel konuşma yetisi kazanmak istiyorsak, kitaplar bizim ebedî dostlarımız olmalıdır.",
                    Image="kitaplar.jpg",
                    PublishDate=DateTime.Now.AddDays(-3),
                    isPopular=true,
                    isPublish=false,
                    category=context.Categories.Where(i=>i.Id==4).FirstOrDefault(),
                    author=context.Authors.Where(i=>i.Id==8).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="Değişim",
                    Description="İnsan denilen varlık değişmeye o kadar müsait ki. Neden mi? Çünkü düşünebilen tek yaratık...",
                    Detail="İnsan denilen varlık değişmeye o kadar müsait ki... Neden mi? Çünkü düşünebilen tek yaratık... Düşünebilen bir varlık değişmez mi? Elbette değişir... Her gün değil her dakika değişir hem de... Kimisi iyi anlamda kimisi kötü anlamda...  Kimisi kendini geliştirerek değişir, kimisi kendini dibe çekerek değişir... Olduğu yerde sayanlar mı? Kuşkusuz onlarda kendini dibe çekenler arasında...  Hedefi olmayıp boş boş yaşayan, ailesine önem vermeyen, küfür’ü ağzında sakız edinen, dedikodu yapmadan duramayan insanlar hangi gruptadır; hedefi için her gün bir şeyler yapan, ailesine önem veren, insanlara saygılı, ne söylediğini bilen insanlar hangi gruptadır hadi buna bir cevap verin...   Peki hangi kategoride olmak daha iyi?  “Ne lanet adam, tembel, elinden bir iş gelmez, onunla muhatap olunmaz” diye mi düşünse daha iyi çevrenizdekiler yoksa; “ne kadar iyi bir insan, çalışkan, hoşsohbet” diye mi düşünülse daha iyi? Ne kadar güzel ki; Yüce Yaradan bizlere düşünebilme yetisi vermiş, iyiyi güzeli huy edinelim diye Kutsal Kitabımızı göndermiş...E neden be insanoğlu, neden kötüyü örnek alırsın kendine?  Değişim demiştim değil mi? Düşünebilen varlık dedim insanlar için... Evet işte onlar bugün beğendiğini yarın beğenmez...Dün beğenmediğini de bugün beğenebilir... Oysa hayvanlar öyle mi? Köpek kediden hoşlanmıyorsa her zaman hoşlanmayacak demektir, değişmez...Ya bitkiler öyle mi? Yoo onlar da öyle değil... Çiçekler suyu dünde seviyordur bugünde...Onlarda değişir elbette ama elinde olmadan, bilinçli bir şekilde değil insanlar gibi... Uzun tüyleri olan bir köpeği tıraş ettirirsin görüntüsü değişir, çiçeğe su vermezsin solar… Bakın onların değişimi bile insanoğluna bağlı...  Geçen sene ton balığı yerdim neredeyse her gün, oysa şimdi hoşlanmıyorum. Siyah saç favorimdi şimdi ise kahverengi, yaşadığım şehri sevmiyordum artık seviyorum… Şu an yazdığım yazıyı bugün beğeniyorum belki yarın beğenmeyeceğim...  Neden evlenen insanlar olduğu kadar boşananlarda var? Nedenlerinden biri eşine karşı beğenisinin azalması değil mi bazı kişilerin, beğenisinin azalmasında, önceden kendine iyi bakan eşinin sonradan kendini boş vermesi de olamaz mı? Buyurun değişen bir çift... E tersi de var tabi, sevmeyerek evlenen kişilerin de zamanla birbirlerine karşı sevgi ve saygısı artabilir… O da bir değişim...  Hayatını iyi bir insan olarak geçiren bir kişi katil ya da hırsız olabilir pekâlâ, kötü bir insanda tövbe ederek iyi bir insan olabilir...  Herkesinde bildiği gibi değişmeyen tek şey değişim...Hayatınıza mutluluk ve başarı getirecek iyi anlamda olan değişimlerinizin fazla olması dileği ile...",
                    Image="people.jpg",
                    PublishDate=DateTime.Now.AddDays(-1),
                    isPopular=true,
                    isPublish=true,
                    category=context.Categories.Where(i=>i.Id==6).FirstOrDefault(),
                    author=context.Authors.Where(i=>i.Id==8).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="Sevgi ve Hoşgörü",
                    Description="Dünya’da ve Türkiye’de her zaman ihtiyaç duyulan konu, sevgi ve hoşgörüdür. Bu günlerde yaşadığımız olaylar, sevgiye ve hoşgörüye ne kadar muhtaç olduğumuzu gösteriyor.",
                    Detail="Dünya’da ve Türkiye’de her zaman ihtiyaç duyulan konu, sevgi ve hoşgörüdür. Bu günlerde yaşadığımız olaylar, sevgiye ve hoşgörüye ne kadar muhtaç olduğumuzu gösteriyor. İnsan; sevgi ve gönül’e verilen değer ışığında insanlığın anlamını anlar. Amaç; sevgi, dostluk ve barıştır.Bu yolla insanların gerek kendileriyle, gerekse çevresiyle kaynaşmasına, barışık olmasına ve sonsuz hayatta yeniden doğmasına yardımcı olur.Sevgide gönül; alemin göz bebeğidir. Sevgi ve hoşgörü denilince de Yunus Emre akla gelir..Öyle ki, Yunus Emre gönül için, Hakk'ın tahtı, der. Gönül Çalab’ın tahtı, gönüle Çalab baktı İki cihan bedbahtı, kim gönül yıkarsa,Yunus Emre; seslendiği insanların toplumdaki seviyelerine bakmadığı gibi, onları dinine, mezhebine, ırkına ve rengine göre de ayırmamıştır. Bu gönülle Yunus Emre tüm insanlığı kucaklayan bir tutum izlemiştir. Yunus Emre; ayrılıkçı değil, birlikçi, birleştirici bir insandır. Yunus dili ile özetlersek: Gelin tanış olalım, İşi kolay kılalım, Sevelim, sevilelim, Bu dünya kimseye kalmaz, Ben gelmedim davi için, Benim işim sevi için, Gönüller dost evi için, Gönüller yapmaya geldim..  İnsanı, hayvanı, doğayı, evreni çok ama çok sevin. Bu sevginizi hoşunuza giden hareketler yaptığında da, hoşunuza gitmeyen hareketler yaptığında da muhafaza edin.Kalbinizi her daim sağlam tutun.Her türlü hava şartında mutlu ve sevgiyle uçun.",
                    Image="hosgoru.jpg",
                    isPopular=true,
                    PublishDate=DateTime.Now.AddDays(-2),
                    isPublish=false,
                    category=context.Categories.Where(i=>i.Id==5).FirstOrDefault(),
                    author=context.Authors.Where(i=>i.Id==10).FirstOrDefault()
                },
                new Entity.Blog()
                {
                    Title="Zamanı Nasıl Yönetmeliyiz?",
                    Description="Profesör sınıfa girip karşısında duran Dünya'nın en seçilmiş öğrencilerine kısa bir süre baktıktan sonra, 'Bugün Zaman Yönetimi konusunda deneyle karışık bir sınav yapacağız' dedi.",
                    Detail="Profesör sınıfa girip karşısında duran Dünya'nın en seçilmiş öğrencilerine kısa bir süre baktıktan sonra, 'Bugün Zaman Yönetimi konusunda deneyle karışık bir sınav yapacağız' dedi. Kürsüye yürüdü, kürsünün altından kocaman bir kavanoz çıkarttı. Arkadan, kürsünün altından bir düzine yumruk büyüklüğünde taş aldı ve taşları büyük bir dikkatle kavanozun içine yerleştirmeye başladı. Kavanozun daha başka taş almayacağına emin olduktan sonra öğrencilerine döndü ve 'Bu kavanoz doldu mu?' diye sordu. Öğrenciler hep bir ağızdan 'Doldu' diye cevapladılar. Profesör 'Öyle mi?' dedi ve kürsünün altına eğilerek bir kova mıcır çıkarttı. Mıcırı kavanozun ağzından yavaş yavaş döktü. Sonra kavanozu sallayarak mıcırın taşların arasına yerleşmesini sağladı. Sonra öğrencilerine dönerek bir kez daha 'Bu kavanoz doldu mu?' diye sordu. Bir öğrenci 'Dolmadı herhâlde' diye cevap verdi. 'Doğru' dedi profesör ve gene kürsünün altına eğilerek bir kova kum aldı ve yavaş yavaş tüm kum taneleri taşlarla mıcırların arasına nüfuz edene kadar döktü. Gene öğrencilerine döndü ve 'Bu kavanoz doldu mu?' diye sordu. Tüm sınıftakiler bir ağızdan 'Hayır' diye bağırdılar. 'Güzel' dedi profesör ve kürsünün altına eğilerek bir sürahi su aldı ve kavanoz ağzına kadar doluncaya dek suyu boşalttı. Sonra öğrencilerine dönerek 'Bu deneyin amacı neydi' diye sordu. Uyanık bir öğrenci hemen 'Zamanımız ne kadar dolu görünürse görünsün, daha ayırabileceğimiz zamanımız mutlaka vardır' diye atladı. 'Hayır' dedi profesör, 'bu deneyin esas anlatmak istediği eğer büyük taşları bastan yerleştirmezseniz küçükler girdikten sonra büyükleri hiç bir zaman kavanozun içine koyamazsınız' gerçeğidir''. Öğrenciler şaşkınlık içinde birbirlerine bakarken profesör devam etti: 'Nedir hayatınızdaki büyük taşlar? Çocuklarınız, eşiniz, sevdikleriniz, arkadaşlarınız, eğitiminiz, hayâlleriniz, sağlığınız, bir eser yaratmak, başkalarına faydalı olmak, onlara bir şey öğretmek! Büyük taşlarınız belki bunlardan birisi, belki bir kaçı, belki hepsi. Bu akşam uykuya yatmadan önce iyice düşünün ve sizin büyük taşlarınız hangileridir iyi karar verin. Bilin ki büyük taşlarınızı kavanoza ilk olarak yerleştirmezseniz hiç bir zaman bir daha koyamazsınız, o zaman da ne kendinize, ne de çalıştığınız kuruma, ne de ülkenize faydalı olursunuz. Bu da iyi bir iş adamı, gerçekte de iyi bir adam olamayacağınızı gösterir' Profesör, ders bittiği hâlde konuşmadan oturan öğrencileri sınıfta bırakarak çıktı ",
                    Image="zaman.jpg",
                    PublishDate=DateTime.Now,
                    isPopular=true,
                    isPublish=true,
                    category=context.Categories.Where(i=>i.Id==2).FirstOrDefault(),
                    author=context.Authors.Where(i=>i.Id==11).FirstOrDefault()
                }


            };
            foreach (var blog in bloglist)
            {
                context.Blogs.Add(blog);
            }
            context.SaveChanges();
            #endregion
        }
    }
}