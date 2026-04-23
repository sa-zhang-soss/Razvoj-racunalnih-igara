#include "Warrior.hpp"
#include <iostream>

Warrior::Warrior(const std::string& name)
    : Character(name, 120, 15, 10) {
}

void Warrior::specialAbility(Character& target) {
    std::cout << name << " koristi BLOCK\n";
    defense += 5;
}