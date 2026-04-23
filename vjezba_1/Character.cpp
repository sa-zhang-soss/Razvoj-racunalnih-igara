#include "Character.hpp"
#include "Inventory.hpp"
#include "Item.hpp"

Character::Character(const std::string& name, int hp, int atk, int def)
    : name(name), hp(hp), maxHp(hp), attackPower(atk), defense(def), inventory(nullptr) {
}

Character::~Character() {}

void Character::attack(Character& target) {
    int dmg = attackPower - target.getDefense();
    if (dmg < 0) dmg = 0;

    std::cout << name << " napada " << target.getName() << " za " << dmg << " dmg\n";
    target.takeDamage(dmg);
}

void Character::takeDamage(int dmg) {
    hp -= dmg;
    if (hp < 0) hp = 0;
}

bool Character::isAlive() const {
    return hp > 0;
}

void Character::setInventory(Inventory* inv) {
    inventory = inv;
}

void Character::useItem(int index) {
    if (inventory) {
        inventory->useItem(index, *this);
    }
}

void Character::printStatus() const {
    std::cout << name << " HP: " << hp << "/" << maxHp << "\n";
}

std::string Character::getName() const { return name; }
int Character::getAttack() const { return attackPower; }
int Character::getDefense() const { return defense; }