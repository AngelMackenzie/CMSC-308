// Abstract class
abstract class Animal {
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep() {
    System.out.println("Zzz");
  }
}

// Subclass (inherit from Animal)
class Cat extends Animal {
  public void animalSound() {
   
    System.out.println("Cat says: Meow! Meow!!");
  }
}

class Main {
  public static void main(String[] args) {
    Cat myCat = new Cat();
    myCat.animalSound();
    myCat.sleep();
  }
}
