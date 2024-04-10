```mermaid
sequenceDiagram
participant User
participant Sphere1
participant Sphere2
participant Sphere3
User->>Sphere1: Throw()
User->>Sphere2: Throw()
User->>Sphere3: Throw()
User->>Sphere1: Pop()
Sphere1->>Sphere1: Raio = 0
Note over Sphere1, Sphere2, Sphere3: Print sphere state
User->>+Console: WriteLine
Note over Console: Sphere 1: Color = <cor1>, Raio = 0, times thrown = 1
User->>+Console: WriteLine
Note over Console: Sphere 2: Color = <cor2>, Raio = 75, times thrown = 1
User->>+Console: WriteLine
Note over Console: Sphere 3: Color = <cor3>, Raio = 100, times thrown = 1
```