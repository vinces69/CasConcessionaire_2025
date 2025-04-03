-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  jeu. 23 mars 2023 à 15:50
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_concession`
--

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `IDCOMMANDE` int(11) NOT NULL AUTO_INCREMENT,
  `DATECOMMANDE` date NOT NULL,
  `FINISSIONPRENIUM` tinyint(1) NOT NULL,
  `OPTIONENRCONDUITE` tinyint(1) DEFAULT NULL,
  `OPTIONPHARE` tinyint(1) DEFAULT NULL,
  `OPTIONCOFFRE` tinyint(1) DEFAULT NULL,
  `OPTIONGRILLE` tinyint(1) DEFAULT NULL,
  `NOMCLIENT` varchar(150) NOT NULL,
  `PRENOMCLIENT` varchar(150) NOT NULL,
  `IDCOULEUR` int(11) NOT NULL,
  `IDMODELE` int(11) NOT NULL,
  `IDETATCOMMANDE` int(2) NOT NULL,
  PRIMARY KEY (`IDCOMMANDE`),
  KEY `Commande_Couleur_FK` (`IDCOULEUR`),
  KEY `Commande_Modele0_FK` (`IDMODELE`),
  KEY `Commande_Etat_FK` (`IDETATCOMMANDE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `couleur`
--

DROP TABLE IF EXISTS `couleur`;
CREATE TABLE IF NOT EXISTS `couleur` (
  `IDCOULEUR` int(11) NOT NULL AUTO_INCREMENT,
  `LABELCOULEUR` varchar(50) NOT NULL,
  PRIMARY KEY (`IDCOULEUR`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `couleur`
--

INSERT INTO `couleur` (`IDCOULEUR`, `LABELCOULEUR`) VALUES
(1, 'Bleu'),
(2, 'Rouge'),
(3, 'Vert'),
(4, 'Noir'),
(5, 'Gris'),
(6, 'Blanc');

-- --------------------------------------------------------

--
-- Structure de la table `etatcommande`
--

DROP TABLE IF EXISTS `etatcommande`;
CREATE TABLE IF NOT EXISTS `etatcommande` (
  `IDETATCOMMANDE` int(2) NOT NULL AUTO_INCREMENT,
  `LABELETATCOMMANDE` varchar(255) NOT NULL,
  PRIMARY KEY (`IDETATCOMMANDE`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `etatcommande`
--

INSERT INTO `etatcommande` (`IDETATCOMMANDE`, `LABELETATCOMMANDE`) VALUES
(1, 'en cours de fabrication'),
(2, 'en cours de livraison'),
(3, 'en attente de paiement'),
(4, 'livré');

-- --------------------------------------------------------

--
-- Structure de la table `modele`
--

DROP TABLE IF EXISTS `modele`;
CREATE TABLE IF NOT EXISTS `modele` (
  `IDMODELE` int(11) NOT NULL AUTO_INCREMENT,
  `LABELMODELE` varchar(50) NOT NULL,
  PRIMARY KEY (`IDMODELE`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `modele`
--

INSERT INTO `modele` (`IDMODELE`, `LABELMODELE`) VALUES
(1, 'Honda E'),
(2, 'Jazz'),
(3, 'CR-V '),
(4, 'HR-V'),
(5, 'CIVIC');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `Commande_Couleur_FK` FOREIGN KEY (`IDCOULEUR`) REFERENCES `couleur` (`IDCOULEUR`),
  ADD CONSTRAINT `Commande_Etat_FK` FOREIGN KEY (`IDETATCOMMANDE`) REFERENCES `etatcommande` (`IDETATCOMMANDE`),
  ADD CONSTRAINT `Commande_Modele0_FK` FOREIGN KEY (`IDMODELE`) REFERENCES `modele` (`IDMODELE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
