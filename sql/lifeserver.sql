/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : lifeserver

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2019-04-10 21:36:33
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for module_main
-- ----------------------------
DROP TABLE IF EXISTS `module_main`;
CREATE TABLE `module_main` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ModuleName` varchar(255) DEFAULT NULL COMMENT '模块名称',
  `ModuleUrl` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of module_main
-- ----------------------------
INSERT INTO `module_main` VALUES ('1', '首页', 'index.html');
INSERT INTO `module_main` VALUES ('2', '订单中心', 'index.html');
INSERT INTO `module_main` VALUES ('3', '个人中心', 'index.html');

-- ----------------------------
-- Table structure for module_relationformain
-- ----------------------------
DROP TABLE IF EXISTS `module_relationformain`;
CREATE TABLE `module_relationformain` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ModuleId` int(11) DEFAULT NULL,
  `ModulechildenName` varchar(255) DEFAULT NULL COMMENT '子模块名称',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of module_relationformain
-- ----------------------------
INSERT INTO `module_relationformain` VALUES ('1', '1', '家电清洗');
INSERT INTO `module_relationformain` VALUES ('2', '1', '清洗套餐');
INSERT INTO `module_relationformain` VALUES ('3', '1', '居家换新');
INSERT INTO `module_relationformain` VALUES ('4', null, '健康生活');

-- ----------------------------
-- Table structure for user_maininfo
-- ----------------------------
DROP TABLE IF EXISTS `user_maininfo`;
CREATE TABLE `user_maininfo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL COMMENT '姓名',
  `Sex` varchar(255) DEFAULT NULL COMMENT '性别',
  `Guid` varchar(255) DEFAULT NULL,
  `Phone` varchar(255) DEFAULT NULL,
  `Adress` varchar(255) DEFAULT NULL,
  `InvitationCode` varchar(255) DEFAULT NULL COMMENT '邀请码',
  `Type` varchar(255) DEFAULT NULL COMMENT '用户类型',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user_maininfo
-- ----------------------------
