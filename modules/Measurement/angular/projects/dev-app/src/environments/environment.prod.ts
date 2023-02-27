import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Measurement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44326/',
    redirectUri: baseUrl,
    clientId: 'Measurement_App',
    responseType: 'code',
    scope: 'offline_access Measurement',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44326',
      rootNamespace: 'Lab.Measurement',
    },
    Measurement: {
      url: 'https://localhost:44364',
      rootNamespace: 'Lab.Measurement',
    },
  },
} as Environment;
