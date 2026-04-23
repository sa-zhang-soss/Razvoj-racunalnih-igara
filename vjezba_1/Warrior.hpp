#ifndef WARRIOR_HPP
#define WARRIOR_HPP

#include "Character.hpp"

class Warrior : public Character {
public:
    Warrior(const std::string& name);
    void specialAbility(Character& target) override;
};

#endif