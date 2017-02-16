﻿[{
    "countryCode": "US",
    "name": {
        "en_US": "United States"
    },
    "continent": "northamerica",
    "locales": ["en_US"],
    "currencyCode": "USD",
    "taxation": {
        "type": "net"
    },
    "priceBooks": [
		"usd-list-prices",
		"usd-sale-prices"
    ],
    "dynamicForms": {
        "addressDetails": {
            "country": {
                "type": "select"
            },
            "states": [{
                "fieldName": "state",
                "type": "select",
                "required": true
            }],
            "address2": {
                "help": {
                    "cid": "apo-fpo",
                    "label": {
                        "property": "singleshipping.apofpo",
                        "file": "checkout"
                    }
                }
            },
            "phone": {
                "help": {
                    "cid": "help-telephone",
                    "label": {
                        "property": "singleshipping.phonerequired",
                        "file": "checkout"
                    }
                }
            }
        },
        "giftRegistryEvent": {
            "eventaddress": [{
                "fieldName": "country",
                "type": "select"
            }, {
                "fieldName": "states.state",
                "type": "select",
                "required": true
            }],
            "type": {
                "type": "select"
            }
        },
        "giftRegistrySearch": {
            "simple": {
                "eventType": {
                    "type": "select"
                }
            },
            "advanced": {
                "eventMonth": {
                    "type": "select"
                },
                "eventYear": {
                    "type": "select"
                },
                "eventAddress": [{
                    "fieldName": "states.state",
                    "type": "select"
                }, {
                    "fieldName": "country",
                    "type": "select"
                }]
            }
        },
        "expirationInfo": {
            "year": {
                "type": "select",
                "rowclass": "year"
            },
            "month": {
                "type": "select",
                "rowclass": "month"
            }
        }
    }
}, {
    "countryCode": "GB",
    "name": {
        "en_GB": "United Kingdom"
    },
    "continent": "europe",
    "locales": ["en_GB"],
    "currencyCode": "GBP",
    "taxation": {
        "type": "gross"
    },
    "priceBooks": [
		"gbp-list-prices",
		"gbp-sale-prices"
    ],
    "dynamicForms": {
        "addressDetails": {
            "country": {
                "type": "select"
            },
            "states": [{
                "fieldName": "state",
                "type": "input"
            }],
            "phone": {
                "help": {
                    "cid": "help-telephone",
                    "label": {
                        "property": "singleshipping.phonerequired",
                        "file": "checkout"
                    }
                }
            }
        },
        "giftRegistryEvent": {
            "eventaddress": [{
                "fieldName": "country",
                "type": "select"
            }, {
                "fieldName": "states.state"
            }],
            "type": {
                "type": "select"
            }
        },
        "giftRegistrySearch": {
            "simple": {
                "eventType": {
                    "type": "select"
                }
            },
            "advanced": {
                "eventMonth": {
                    "type": "select"
                },
                "eventYear": {
                    "type": "select"
                },
                "eventAddress": [{
                    "fieldName": "states.state"
                }, {
                    "fieldName": "country",
                    "type": "select"
                }]
            }
        },
        "expirationInfo": {
            "year": {
                "type": "select",
                "rowclass": "year"
            },
            "month": {
                "type": "select",
                "rowclass": "month"
            }
        }
    }
}, {
    "countryCode": "JP",
    "name": {
        "ja_JP": "æ—¥æœ¬",
        "en_JP": "Japan"
    },
    "continent": "asia",
    "locales": ["ja_JP", "en_JP"],
    "currencyCode": "JPY",
    "taxation": {
        "type": "gross",
        "rate": 0.1
    },
    "priceBooks": [
		"jpy-list-prices",
		"jpy-sale-prices"
    ],
    "dynamicForms": {
        "addressDetails": {
            "country": {
                "type": "select"
            },
            "states": [{
                "fieldName": "state",
                "type": "select",
                "required": true
            }],
            "phone": {
                "help": {
                    "cid": "help-telephone",
                    "label": {
                        "property": "singleshipping.phonerequired",
                        "file": "checkout"
                    }
                }
            }
        },
        "giftRegistryEvent": {
            "eventaddress": [{
                "fieldName": "country",
                "type": "select"
            }, {
                "fieldName": "states.state",
                "type": "select",
                "required": true
            }],
            "type": {
                "type": "select"
            }
        },
        "giftRegistrySearch": {
            "simple": {
                "eventType": {
                    "type": "select"
                }
            },
            "advanced": {
                "eventMonth": {
                    "type": "select"
                },
                "eventYear": {
                    "type": "select"
                },
                "eventAddress": [{
                    "fieldName": "states.state",
                    "type": "select"
                }, {
                    "fieldName": "country",
                    "type": "select"
                }]
            }
        },
        "expirationInfo": {
            "year": {
                "type": "select",
                "rowclass": "year"
            },
            "month": {
                "type": "select",
                "rowclass": "month"
            }
        }
    }
}, {
    "countryCode": "CN",
    "name": {
        "zh_CN": "ä¸­å›½",
        "en_CN": "China"
    },
    "continent": "asia",
    "locales": ["zh_CN", "en_CN"],
    "currencyCode": "CNY",
    "taxation": {
        "type": "gross",
        "rate": 0.17
    },
    "priceBooks": [
		"cny-list-prices",
		"cny-sale-prices"
    ],
    "dynamicForms": {
        "addressDetails": {
            "country": {
                "type": "select"
            },
            "states": [{
                "fieldName": "state",
                "type": "input",
                "required": true
            }],
            "phone": {
                "help": {
                    "cid": "help-telephone",
                    "label": {
                        "property": "singleshipping.phonerequired",
                        "file": "checkout"
                    }
                }
            }
        },
        "giftRegistryEvent": {
            "eventaddress": [{
                "fieldName": "country",
                "type": "select"
            }, {
                "fieldName": "states.state",
                "required": true
            }],
            "type": {
                "type": "select"
            }
        },
        "giftRegistrySearch": {
            "simple": {
                "eventType": {
                    "type": "select"
                }
            },
            "advanced": {
                "eventMonth": {
                    "type": "select"
                },
                "eventYear": {
                    "type": "select"
                },
                "eventAddress": [{
                    "fieldName": "states.state"
                }, {
                    "fieldName": "country",
                    "type": "select"
                }]
            }
        },
        "expirationInfo": {
            "year": {
                "type": "select",
                "rowclass": "year"
            },
            "month": {
                "type": "select",
                "rowclass": "month"
            }
        }
    }
}, {
    "countryCode": "FR",
    "name": {
        "fr_FR": "France"
    },
    "continent": "europe",
    "locales": ["fr_FR"],
    "currencyCode": "EUR",
    "taxation": {
        "type": "gross",
        "rate": 0.2
    },
    "priceBooks": [
		"eur-list-prices",
		"eur-sale-prices"
    ],
    "dynamicForms": {
        "addressDetails": {
            "country": {
                "type": "select"
            },
            "states": {
                "skip": true
            },
            "phone": {
                "help": {
                    "cid": "help-telephone",
                    "label": {
                        "property": "singleshipping.phonerequired",
                        "file": "checkout"
                    }
                }
            }
        },
        "giftRegistryEvent": {
            "eventaddress": [{
                "fieldName": "country",
                "type": "select"
            }, {
                "fieldName": "states.state"

            }],
            "type": {
                "type": "select"
            }
        },
        "giftRegistrySearch": {
            "simple": {
                "eventType": {
                    "type": "select"
                }
            },
            "advanced": {
                "eventMonth": {
                    "type": "select"
                },
                "eventYear": {
                    "type": "select"
                },
                "eventAddress": [{
                    "fieldName": "states.state"
                }, {
                    "fieldName": "country",
                    "type": "select"
                }]
            }
        },
        "expirationInfo": {
            "year": {
                "type": "select",
                "rowclass": "year"
            },
            "month": {
                "type": "select",
                "rowclass": "month"
            }
        }
    }
}, {
    "countryCode": "IT",
    "name": {
        "it_IT": "Italia"
    },
    "continent": "europe",
    "locales": ["it_IT"],
    "currencyCode": "EUR",
    "taxation": {
        "type": "gross",
        "rate": 0.22
    },
    "priceBooks": [
		"eur-list-prices",
		"eur-sale-prices"
    ],
    "dynamicForms": {
        "addressDetails": {
            "country": {
                "type": "select"
            },
            "states": [{
                "fieldName": "state",
                "type": "select",
                "required": true
            }],
            "phone": {
                "help": {
                    "cid": "help-telephone",
                    "label": {
                        "property": "singleshipping.phonerequired",
                        "file": "checkout"
                    }
                }
            }
        },
        "giftRegistryEvent": {
            "eventaddress": [{
                "fieldName": "country",
                "type": "select"
            }, {
                "fieldName": "states.state",
                "type": "select",
                "required": true
            }],
            "type": {
                "type": "select"
            }
        },
        "giftRegistrySearch": {
            "simple": {
                "eventType": {
                    "type": "select"
                }
            },
            "advanced": {
                "eventMonth": {
                    "type": "select"
                },
                "eventYear": {
                    "type": "select"
                },
                "eventAddress": [{
                    "fieldName": "states.state",
                    "type": "select"
                }, {
                    "fieldName": "country",
                    "type": "select"
                }]
            }
        },
        "expirationInfo": {
            "year": {
                "type": "select",
                "rowclass": "year"
            },
            "month": {
                "type": "select",
                "rowclass": "month"
            }
        }
    }
}, {
    "countryCode": "JE",
    "name": {
        "en_JE": "Jersey"
    },
    "continent": "Europe",
    "locales": ["en_JE"],
    "currencyCode": "GBP",
    "taxation": {
        "type": "gross",
        "rate": 0.22
    },
    "priceBooks": [
		"eur-list-prices",
		"eur-sale-prices"
    ]
}]
