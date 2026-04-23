#include "HealingPotion.hpp"
#include "Character.hpp"
#include <iostream>

void HealingPotion::use(Character& target) {
    std::cout << "Healing potion used!\n";
    target.takeDamage(-30);
}