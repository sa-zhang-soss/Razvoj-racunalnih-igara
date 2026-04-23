#include "Mage.hpp"
#include <iostream>

Mage::Mage(const std::string& name)
    : Character(name, 80, 20, 5), mana(50) {
}

void Mage::specialAbility(Character& target) {
    if (mana >= 10) {
        std::cout << name << " baca FIREBALL\n";
        target.takeDamage(30);
        mana -= 10;
    }
}