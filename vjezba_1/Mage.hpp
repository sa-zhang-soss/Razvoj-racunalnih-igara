#ifndef MAGE_HPP
#define MAGE_HPP

#include "Character.hpp"

class Mage : public Character {
    int mana;

public:
    Mage(const std::string& name);
    void specialAbility(Character& target) override;
};

#endif
