classDiagram
    class User {
        <<abstract>>
        #string name
        +DisplayInfo()*
    }
    class Member {
        -int memberId
        +Member(string name, int id)
        +DisplayInfo()
    }
    class Book {
        -string title
        -string author
        -bool isAvailable
        +Title string
        +IsAvailable bool
        +Book(string title, string author)
    }
    User <|-- Member
    Program ..> Member
    Program ..> Book

sequenceDiagram
    participant P as Program
    participant M as Member
    participant B as Book
    P->>M: new Member("John Doe", 101)
    P->>B: new Book("UML Distilled", "Martin Fowler")
    P->>M: DisplayInfo()
    P->>B: get IsAvailable
    alt IsAvailable == true
        P->>B: set IsAvailable = false
    end
stateDiagram-v2
    [*] --> Disponibil
    Disponibil --> Imprumutat: IsAvailable = false
    Imprumutat --> Disponibil: IsAvailable = true

    
    
    
