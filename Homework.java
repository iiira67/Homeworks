import java.util.*;

// Класс, описывающий ноутбук

class Laptop {

    private String model;

    private int ram;

    private int hddSize;

    private String os;

    private String color;

    // Конструктор класса Laptop

    public Laptop(String model, int ram, int hddSize, String os, String color) {

        this.model = model;

        this.ram = ram;

        this.hddSize = hddSize;

        this.os = os;

        this.color = color;

    }

    // Для доступа к полям

    public String getModel() {

        return model;

    }

    public int getRam() {

        return ram;

    }

    public int getHddSize() {

        return hddSize;

    }

    public String getOs() {

        return os;

    }

    public String getColor() {

        return color;

    }

}

// Класс, представляющий магазин ноутбуков

class Store {

    private Set<Laptop> laptops;

    // Конструктор класса Store

    public Store() {

        laptops = new HashSet<>();

    }

    // Метод для добавления ноутбука в магазин

    public void addLaptop(Laptop laptop) {

        laptops.add(laptop);

    }

    // Метод для фильтрации ноутбуков по заданным критериям

    public void filterLaptops(Map<String, Object> filters) {

        for (Laptop laptop : laptops) {

            boolean passesFilter = true;

            for (Map.Entry<String, Object> entry : filters.entrySet()) {

                String key = entry.getKey();

                Object value = entry.getValue();

                switch (key) {

                    case "ram":

                        if (laptop.getRam() < (int) value) {

                            passesFilter = false;

                        }

                        break;

                    case "hddSize":

                        if (laptop.getHddSize() < (int) value) {

                            passesFilter = false;

                        }

                        break;

                    case "os":

                        if (!laptop.getOs().equals((String) value)) {

                            passesFilter = false;

                        }

                        break;

                    case "color":

                        if (!laptop.getColor().equals((String) value)) {

                            passesFilter = false;

                        }

                        break;

                }

            }

            if (passesFilter) {

                System.out.println("Найден ноутбук: " + laptop.getModel());

            }

        }

    }

}

public class Homework {

    public static void main(String[] args) {

        Store store = new Store();

        Laptop laptop1 = new Laptop("HP Pavilion", 8, 512, "Windows", "Silver");

        Laptop laptop2 = new Laptop("Dell Inspiron", 16, 1024, "Linux", "Black");

        store.addLaptop(laptop1);

        store.addLaptop(laptop2);

        Map<String, Object> filters = new HashMap<>();

        filters.put("ram", 8);

        filters.put("os", "Windows");

        System.out.println("Результаты фильтрации:");

        store.filterLaptops(filters);

    }

}
