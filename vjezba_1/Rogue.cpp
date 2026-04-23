#include "Rogue.hpp"
#include <cstdlib>
#include <iostream>

Rogue::Rogue(const std::string& name)
    : Character(name, 90, 18, 6) {
}

void Rogue::specialAbility(Character& target) {
    if (rand() % 2 == 0) {
        std::cout << "CRITICAL HIT!\n";
        target.takeDamage(35);
    }
    else {
        attack(target);
    }
}