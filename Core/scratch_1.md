# **Ejercicio Avanzado de C#: Sistema de Reservas para una Aerolínea con POO y SOLID**  

## **Descripción del Proyecto**  
Debes implementar un sistema de gestión de reservas para una aerolínea que cumpla con:  
- **Programación Orientada a Objetos (POO)**: Clases, herencia, polimorfismo, encapsulamiento, abstracción.  
- **Principios SOLID**: Cada componente debe seguir Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation y Dependency Inversion.  
- **Patrones de Diseño**: Se espera el uso de al menos 3 patrones (Factory, Strategy, Observer, Decorator, etc.).  

---

## **Requisitos Funcionales**  

### **1. Gestión de Vuelos**  
- Cada vuelo tiene:  
  - Código de vuelo (ej: "AA123")  
  - Origen y destino (ciudades)  
  - Fecha y hora de salida/llegada  
  - Capacidad máxima de pasajeros  
  - Estado (Disponible, Completo, Cancelado, Retrasado)  

### **2. Gestión de Pasajeros**  
- Tipos de pasajeros:  
  - **Económico**: Sin beneficios adicionales.  
  - **Premium**: Prioridad en embarque, maleta adicional gratis.  
  - **VIP**: Acceso a lounge, cambios gratuitos.  

### **3. Sistema de Reservas**  
- Un pasajero puede reservar uno o más vuelos.  
- Cada reserva tiene:  
  - ID único  
  - Pasajero asociado  
  - Vuelo(s) reservado(s)  
  - Clase (Económica, Business, Primera)  
  - Precio (varía según clase y tipo de pasajero)  
  - Estado (Confirmada, Cancelada, En espera)  

### **4. Notificaciones**  
- Los pasajeros deben recibir notificaciones cuando:  
  - Su vuelo sufre cambios (retraso, cancelación).  
  - Hay promociones disponibles.  

### **5. Políticas de Precios y Descuentos**  
- El precio base depende de la clase (Económica, Business, Primera).  
- Descuentos aplicables según:  
  - Tipo de pasajero (Premium/VIP).  
  - Temporada (alta/baja demanda).  
  - Promociones especiales.  

---

## **Requisitos Técnicos (SOLID + Patrones)**  

### **1. Principio de Responsabilidad Única (SRP)**  
- Separar claramente:  
  - Lógica de vuelos.  
  - Gestión de pasajeros.  
  - Proceso de reservas.  
  - Cálculo de precios.  
  - Sistema de notificaciones.  

### **2. Principio Abierto/Cerrado (OCP)**  
- El sistema debe permitir añadir nuevos:  
  - Tipos de pasajeros (ej: "Pasajero Corporativo").  
  - Formas de notificación (ej: WhatsApp, SMS).  
  - Estrategias de descuento.  

### **3. Principio de Sustitución de Liskov (LSP)**  
- Si se crea una nueva clase de pasajero, debe poder usarse en lugar de la base sin romper el sistema.  

### **4. Principio de Segregación de Interfaces (ISP)**  
- Interfaces específicas para:  
  - Reservas (`IReservable`).  
  - Notificaciones (`INotifiable`).  
  - Cálculo de precios (`IPriceCalculator`).  

### **5. Principio de Inversión de Dependencias (DIP)**  
- El módulo de reservas no debe depender de implementaciones concretas de:  
  - Pasajeros.  
  - Vuelos.  
  - Notificaciones.  

### **Patrones de Diseño Obligatorios**  
1. **Factory Method**: Para crear diferentes tipos de pasajeros.  
2. **Strategy**: Para aplicar distintas políticas de precios.  
3. **Observer**: Para notificar cambios en los vuelos.  

---

## **Retos Adicionales (Opcionales)**  
1. **Sistema de Prioridad en Lista de Espera**: Si un vuelo está lleno, los pasajeros pueden entrar en lista de espera y ser notificados si hay cancelaciones.  
2. **Patrón Decorator**: Para añadir servicios adicionales (comida especial, asiento preferencial).  
3. **Unit of Work**: Manejar transacciones al confirmar/cancelar reservas.  

---

## **Entregables Esperados**  
1. **Diagrama de Clases UML** (puedes hacerlo en draw.io o similar).  
2. **Implementación en C#** con:  
   - Clases bien estructuradas.  
   - Inyección de dependencias.  
   - Pruebas unitarias básicas.  

**¿Listo para el desafío?** Empieza diseñando las clases principales antes de escribir código. 🚀