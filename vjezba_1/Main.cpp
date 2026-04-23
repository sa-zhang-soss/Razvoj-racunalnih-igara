#include "Warrior.hpp"
#include "Mage.hpp"
#include "Rogue.hpp"
#include "Inventory.hpp"
#include "HealingPotion.hpp"

int main() {
    Warrior w("Thor");
    Mage m("Merlin");

    Inventory inv1(5);
    Inventory inv2(5);

    w.setInventory(&inv1);
    m.setInventory(&inv2);

    inv1.addItem(new HealingPotion());
    inv2.addItem(new HealingPotion());

    while (w.isAlive() && m.isAlive()) {
        w.attack(m);
        m.specialAbility(w);

        m.useItem(0);

        w.printStatus();
        m.printStatus();

        std::cout << "-----------------\n";
    }

    return 0;
}