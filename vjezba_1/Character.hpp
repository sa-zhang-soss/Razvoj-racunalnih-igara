#ifndef CHARACTER_HPP
#define CHARACTER_HPP

#include <vector>
#include <string>
#include <iostream>

class Item;
class Inventory;

class Character {
protected:
    std::string name;
    int hp;
    int maxHp;
    int attackPower;
    int defense;

    Inventory* inventory;

public:
    Character(const std::string& name, int hp, int atk, int def);
    virtual ~Character();

    virtual void attack(Character& target);
    virtual void takeDamage(int dmg);
    virtual void specialAbility(Character& target) = 0;

    void useItem(int index);

    bool isAlive() const;

    void setInventory(Inventory* inv);

    void printStatus() const;

    std::string getName() const;
    int getAttack() const;
    int getDefense() const;
};

#endif