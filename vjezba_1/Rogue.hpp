#ifndef ROGUE_HPP
#define ROGUE_HPP

#include "Character.hpp"

class Rogue : public Character {
public:
    Rogue(const std::string& name);
    void specialAbility(Character& target) override;
};

#endif#pragma once
