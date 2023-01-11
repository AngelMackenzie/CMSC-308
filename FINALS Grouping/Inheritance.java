class Animal {
  
  String name;
  public void play() {
    System.out.println("We can play");
  }
}

class Dog extends Animal {

  public void display() {
    System.out.println("My dog name is " + name);
  }
}

class Main {
  public static void main(String[] args) {

    Dog aspin = new Dog();
    
    aspin.name = "Takii";
    aspin.display();
    
    aspin.play();

  }
}

