﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

//remplazando clase lucha

namespace BitmonGráfico
{
    class ControllerLucha
    {
        int contadorJugador = 1;
        public List<Jugador> participantes;
        public int idLucha, turno;
        public string estadoLucha;
        public List<Bitmon> allbitmons;

        public ControllerLucha(int idLucha, int turno, string estadoLucha)
        {
            this.participantes = new List<Jugador>();
            this.idLucha = idLucha;
            this.turno = turno;
            this.estadoLucha = estadoLucha;
            allbitmons = new List<Bitmon>();
            Poder Ember = new Poder(10, 1, "Fuego", null, "Ember");             Poder FireFang = new Poder(11, 2, "Fuego", null, "Fire Fang");             Poder FireSpin = new Poder(14, 3, "Fuego", null, "Fire Spin");             Poder Flamethrower = new Poder(15, 5, "Fuego", "Confusion", "Flamethrower");             Poder Iceshard = new Poder(12, 3, "Hielo", null, "Ice Shard");             Poder FrostBreath = new Poder(10, 2, "Hielo", null, "Frost Breath");             Poder PowderSnow = new Poder(6, 1, "Hielo", null, "Powder Snow");             Poder Hypothemia = new Poder(0, 1, "Hielo", "Sueño", "Hypothemia");             Poder WaterGun = new Poder(5, 2, "Agua", null, "Water Gun");             Poder PoisonGun = new Poder(5, 4, "Agua", "Veneno", "Poison Gun");             Poder Bubble = new Poder(12, 4, "Agua", null, "Bubble");             Poder Waterfall = new Poder(16, 5, "Agua", null, "Waterfall");             Poder ThunderShock = new Poder(5, 2, "Electro", null, "Thunder Shock");             Poder Spark = new Poder(6, 5, "Electro", "Paralisis", "Spark");             Poder ChargeBeam = new Poder(8, 4, "Electro", null, "Charge Beam");             Poder VoltSwitch = new Poder(20, 6, "Electro", null, "Volt Switch");              List<Poder> charmonpow = new List<Poder>();             charmonpow.Add(ThunderShock);             charmonpow.Add(Spark);             charmonpow.Add(Ember);             charmonpow.Add(Flamethrower);              Bitmon Charmon = new Bitmon(500, 15, 128, 108, "Charmon", "Fuego", null, charmonpow, null);              List<Poder> bitpow = new List<Poder>();             bitpow.Add(Ember);             bitpow.Add(FireFang);             bitpow.Add(FireSpin);             bitpow.Add(Flamethrower);              Bitmon Bitmeleon = new Bitmon(800, 20, 160, 140, "Bitmeleon", "Fuego", null, bitpow, null);              List<Poder> pikapow = new List<Poder>();             pikapow.Add(ChargeBeam);             pikapow.Add(VoltSwitch);             pikapow.Add(FireFang);             pikapow.Add(FireSpin);              Bitmon Pikamon = new Bitmon(400, 17, 124, 108, "Pikamon", "Electro", null, pikapow, null);              List<Poder> qwertypow = new List<Poder>();             qwertypow.Add(ThunderShock);             qwertypow.Add(Spark);             qwertypow.Add(ChargeBeam);             qwertypow.Add(VoltSwitch);              Bitmon Qwertymon = new Bitmon(700, 22, 200, 154, "Qwertymon", "Electro", null, qwertypow, null);              List<Poder> squipow = new List<Poder>();             squipow.Add(FrostBreath);             squipow.Add(PowderSnow);             squipow.Add(Bubble);             squipow.Add(Waterfall);              Bitmon Squimon = new Bitmon(500, 13, 112, 142, "Squimon", "Agua", null, squipow, null);              List<Poder> worpow = new List<Poder>();             worpow.Add(WaterGun);             worpow.Add(PoisonGun);             worpow.Add(Bubble);             worpow.Add(Waterfall);              Bitmon Worbito = new Bitmon(600, 19, 144, 176, "Worbito", "Agua", null, worpow, null);              List<Poder> icepow = new List<Poder>();             icepow.Add(PoisonGun);             icepow.Add(Iceshard);             icepow.Add(Hypothemia);             icepow.Add(WaterGun);              Bitmon Icemon = new Bitmon(500, 12, 128, 110, "Icemon", "Hielo", null, icepow, null);              List<Poder> dragpow = new List<Poder>();             dragpow.Add(Iceshard);             dragpow.Add(FrostBreath);             dragpow.Add(PowderSnow);             dragpow.Add(Hypothemia);              Bitmon Dragonice = new Bitmon(800, 20, 170, 152, "Dragonice", "Hielo", null, dragpow, null);              List<Poder> tiripow = new List<Poder>();             tiripow.Add(Flamethrower);             tiripow.Add(Hypothemia);             tiripow.Add(PoisonGun);             tiripow.Add(Spark);              Bitmon Tirimon = new Bitmon(600, 17, 132, 136, "Tirimon", "Normal", null, tiripow, null);              List<Poder> naidopow = new List<Poder>();             naidopow.Add(FireSpin);             naidopow.Add(Iceshard);             naidopow.Add(Waterfall);             naidopow.Add(VoltSwitch);              Bitmon Naidormon = new Bitmon(1000, 16, 142, 128, "Naidormon", "Normal", null, naidopow, null);              allbitmons.Add(Charmon);             allbitmons.Add(Bitmeleon);             allbitmons.Add(Pikamon);             allbitmons.Add(Qwertymon);             allbitmons.Add(Squimon);             allbitmons.Add(Worbito);             allbitmons.Add(Icemon);             allbitmons.Add(Dragonice);             allbitmons.Add(Tirimon);             allbitmons.Add(Naidormon);

            // ver como implementar bien el metodo turno

        }
        public void OnagregarJugardor(string nombre)
        {
            if (contadorJugador == 1)
            {
                Jugador jg1 = new Jugador(null, null, nombre, contadorJugador); //revisar como ponerle equipo al jugador al momento de instanciarlo
                contadorJugador += 1;
                participantes.Add(jg1);
                

            }
            if (contadorJugador == 2)
            {
                Jugador jg2 = new Jugador(null, null, nombre, contadorJugador);
                participantes.Add(jg2);
                
            }
        }

        public void AddEquipos(List<string> nombres,int jugador)
        {
            if (jugador == 1)
            {
                foreach(string nombre in nombres)
                {
                    foreach(Bitmon b in allbitmons)
                    {
                        if(b.nombre == nombre)
                        {
                            participantes[0].equipo.Add(b);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            if (jugador == 2)
            {
                foreach (string nombre in nombres)
                {
                    foreach (Bitmon b in allbitmons)
                    {
                        if (b.nombre == nombre)
                        {
                            participantes[1].equipo.Add(b);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        public string GetNombre(string nom)
        {
            return nom;
        }

        public void EleguirActivo(string nombre)
        {

        }
    }
}
