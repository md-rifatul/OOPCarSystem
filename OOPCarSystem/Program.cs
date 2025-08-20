using OOPCarSystem;

Car car1 = new Car("Toyota","Corolla",2010,0);
Car car2 = new Car("Tesla","Model 3",2023,0);

car1.Drive(50);
car2.Drive(120);
car1.Drive(30);

car1.ShowCarInfo();
car2.ShowCarInfo();
