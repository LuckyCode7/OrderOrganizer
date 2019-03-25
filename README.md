# Order Organizer

Project name: OrderOrganizer

Project type: Windows Forms

Program, in which the application was created: Visual Studio 2017

Goal of the program: order management

## Used tools
- C#
- .Net
- Unit Tests

## User manual (PL)

![1](https://user-images.githubusercontent.com/40712810/54930385-7c507300-4f17-11e9-8184-96ba83f79bec.png)

### Nawigacja

Po aplikacji można poruszać się klikając odpowiednio w kolejne przyciski widoczne odpowiednio w górnej belce programu lub poprzez naciśnięcie któregoś z dolnych przycisków: 'Load external files', 'Visualisation', 'Generate report'. 

### Ładowanie bazy danych

W celu załadowania bazy danych należy w pierwszej kolejności wybrać odpowiednie pliki wsadowe (dopuszczalne formaty: .csv, .json, .xml) klikając na przycisk 'Select File'. Spowoduje to wyświetlenie okna dialogowego z którego wybieramy odpowiedni plik (przykładowe pliki znajdują się już w folderze OrderOrganizer/Orders). Nazwa wybranego pliku zostanie wyświetlona poniżej przycisku 'Select File'. W celu zabezpieczenia bazy danych przed duplikatami zamówień nie ma możliwości dodania dwa razy tego samego pliku - gdy użytkownik spróbuje tak zrobić zostanie wyświetlony odpowiedni komunikat. W dalszej kolejności należy załadować wybrane pliki do bazy danych - dokonujemy tego porzez naciśnięcie przycisku 'Load database'. Jeżeli wcześniej nie wybraliśmy żadnych plików aplikacja nie zawaha się nas o tym poinformować. Ostatni przycisk w tej sekcji - 'Clear database' pozwala użytkownikowi na wyczyszczenie bazy danych (wraz z wczytanymi plikami). Jeżeli we wczytanych plikach znajdują się niepoprawnie sformatowane dane zamówienia to zostaną one wyświetlone w wyżej widocznej tabeli z dodatkową informacją o pliku, z którego pochodzą.

![2](https://user-images.githubusercontent.com/40712810/54930479-a3a74000-4f17-11e9-926f-09605e12d6c1.png)

### Wizualizacja

Naciśnięcie przycisku z lupą powoduje przejście do trybu graficznego bazy danych. W powyższej tabeli zostaną wyświetlone wszystkie zamówienia, które zostały poprawnie określone w plikach wsadowych. Kliknięcie w nazwę kolumny powoduje automatyczne sortowanie tabeli.

![3](https://user-images.githubusercontent.com/40712810/54930520-b28df280-4f17-11e9-96ab-b6bfa770e92f.png)

Powyżej została przedstawiona sekcja odpowiedzialna za generowanie raportów. Wybór danych, które mają zostać umieszczone w raporcie jest intuicyjny - dodatkowo aplikacja czuwa nad poprawnym wyborem odpowiednich elementów. Zaznaczenie któregoś z pól umieszczonych w grupie 'Multiple data' odblokowuje dodatkowo możliwość posortowania wybranych zamówień zgodnie z kryterium z grupy 'Group orders by'. Zaznaczenie 'Orders in price range' umożliwia dodatkowo wprowadzenie zakresu cenowego zamówień. Raport może zostać również spersonalizowany pod kątem konkretnego klienta - aby tego dokonać nalezy podać jego 'ClientID' w polu tekstowym poprzedzonym 'Select client ID'. Prdzed wygenerowaniem raportu należy określić jego nazwę (domyślna nazwa to ExampleName). Nazwa pliku nie może pozostać pusta. Generacji raportu doknujemy poprzez naciśnięcie przycisku z ołówkiem. Stworzony raport zostanie zapisany do folderu OrderOrganizer/Reports/NazwaPliku.csv.
