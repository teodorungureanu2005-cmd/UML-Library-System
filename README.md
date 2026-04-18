classDiagram
    class User {
        <<abstract>>
        #string name
        +DisplayInfo()*
    }
    class Member {
        -int memberId
        +DisplayInfo()
    }
    class Book {
        -string title
        -string author
        -bool isAvailable
        +Title string
        +IsAvailable bool
    }
    User <|-- Member
2. Diagrama de Secvență 
sequenceDiagram
    participant P as Program (Main)
    participant M as Member
    participant B as Book

    P->>M: Instanțiere obiect Member
    P->>B: Instanțiere obiect Book
    P->>M: DisplayInfo()
    
    Note over P,B: Procesul de împrumut
    P->>B: Verifică IsAvailable
    alt este disponibilă
        B-->>P: True
        P->>B: Set IsAvailable = false (Update State)
    else este indisponibilă
        B-->>P: False
    end
3. Diagrama de Stare
stateDiagram-v2
    [*] --> Disponibila
    Disponibila --> Imprumutata: Imprumut efectuata
    Imprumutata --> Disponibila: Returnare carte
