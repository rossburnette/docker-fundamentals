FROM node:latest

MAINTAINER Jordan Jordanov

ENV NODE_ENV=production
ENV PORT=3000

COPY . /foo
WORKDIR /foo

VOLUME ["/foo"]

RUN npm install

EXPOSE 3000

ENTRYPOINT ["npm", "start"]