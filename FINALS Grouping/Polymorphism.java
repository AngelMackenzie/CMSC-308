class Animal {
  public void animalSound() {
    System.out.println("The animals make a sound");
  }
}

class Cat extends Animal {
  public void animalSound() {
    System.out.println("Cat Says: meow meow");
  }
}

class Dog extends Animal {
  public void animalSound() {
    System.out.println("Dog says: arf arf");
  }
}

class Main {
  public static void main(String[] args) {
    Animal myAnimal = new Animal();
    Animal myCat = new Cat();  
    Animal myDog = new Dog();  
    myAnimal.animalSound();
    myCat.animalSound();
    myDog.animalSound();
  }
} 
