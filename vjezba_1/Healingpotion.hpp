#ifndef HEALINGPOTION_HPP
#define HEALINGPOTION_HPP

#include "Item.hpp"

class HealingPotion : public Item {
public:
    void use(Character& target) override;
};

#endif