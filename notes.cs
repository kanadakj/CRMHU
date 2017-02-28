konfiguracja dostepow
konfiguracja visualstudio
#
poprawa procedur w bazie integratora HU [scalaDBHungary]
- sqlowa przyrostowa tabela powaizana z geolokalizacja [GetCustomersH1] do sprawdzenia przy pobieraniu klientów 
- sqlowa przyrostowa tabela[GetPriceListsH1]
reploginy dla HU [GetRepCodeKanLoginH1]
	$$ przeniesione, zaczytuja sie normalnie
jak wygladaj kody artyku³ów z wykluczeniami w kontekscie procedury [GetStockItemsH1]
	$$ pozostawiamy tak jak jest -wykluczenia sa ok	--
[viewStockItemsUoMH1] odwoluje sie do 01 i wmsa zostawiamy czy robic wegry i wms
	$$ przenosimy na wegry i usuwamy wms	--
- widoki sprawdzic

kopia solucji
zmian connection stringow i itemow w dbml-ce
lista encji z kartki do wyczyszczenia gdzie skonczylicmy w sobote
jak sytuacja z tlumaczeniami bo to kopiapolskiego i w czesci moze zabraknac tlumaczen
	$$ jezeli bedzie brakowalo tlumaczen bedziemy o robic na biezaco
jak z wzmocnienim wirtualki (przedewszystkim to co ma aby by³o od poczatku -bez przydzielania dynamicznego ewentualnie powylaczac wiecej uslug/procesow zeby dzialalo plynniej)
	$$to co sie dalo wylaczylem, ram zwiekoszony do 32gb wolne 30gb  	--
synchronizacja terminow platnosci

##
----------------------------------
procedura [GetStockItemsH1] pobiera produkty ktore sa oznaczone jako CRM - w HU niema takich warunek  SC01.SC01167 = 1; wymaga oznaczenia lub wszystkie
	$$ oznaczone
procedura [GetStockItemsH1] pobiera artykuly reklamowe niema ja oznaczenia kategori produktu SC01.SC01066 = 5 dodatkowo musi byc oznaczony do CRM; dodajemy ? wywalamy?
	$$ na razie nie ma tam artykułów reklamowych ale na pewno będa
procedura [GetStockItemsH1] jesli dodajemy artykuly reklamowe to czy sa jakieœ magazyny reklamowe; jak tak to jakie numery 
moze to na jakis dokument online przpisac np. onenote bledy poprawi
	$$ przeniosłem na githuba : 
widok [viewStockItemsUoMH1] problem jak wyzej SC01.SC01167 = '1'
	$$ zrobione
slabo z tym wolnym ramem cos jest nie tak ala dzial lepiej masz scryna na pulpicie
	$$ z ramem na virtualkach z wingroza 2008 tak pokazuje wykorzystanie ramu :(
trzeba dodac userow i zrobic jakas strukture
	$$ struktura i looserzy identycznie jak PD w CRMPL - postaram się zrobić to dziś wieczorem
jak powinna byc prawidlowa collacja
	$$ której bazy?
mam problem z procedura [GetCustomersH1] i collacjami jak macie jak to zerknij ewentualnie wywale przyrostowe updaty
	$$ poprawiłem i działa
----------------------------------------
import produktów - dezaktywacja starych
import cennikow narazie tylko 00
import elementów cenników - dezaktywacja starych
usywanie starych danych 
----------------------------------------------
usywanie starych danych 
----------------------------------------------
usywanie starych danych 
----------------------------------------------
usywanie starych danych 
test na nowym kompie - projekt MSPLa nie bilduje sie - narzie niechce na to casu tracic wiec jak nie polepszy sie na wirtualce
	to jeszcze raz zobacze
? nie pobieraja sie ceny katalogowe 
? waluta cennika 00 jest HUF
